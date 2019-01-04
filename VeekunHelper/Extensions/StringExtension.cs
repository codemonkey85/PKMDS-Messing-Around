using Microsoft.EntityFrameworkCore.Design;
using PluralizationService;
using PluralizationService.English;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace VeekunHelper.Extensions
{
    public static class StringExtensions
    {
        #region Entity Naming

        public static string ToSingularEntity(this string value)
        {
            if (value[0] == '_')
            {
                value = value.Substring(1);
            }

            value = value.Replace("_", " ");
            PluralizationServiceInstance ps = new PluralizationServiceInstance();
            value = ps.Singularize(value);
            value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            value = value.Replace(" ", "");

            return value;
        }

        public static string ToEntity(this string value)
        {
            if (value[0] == '_')
            {
                value = value.Substring(1);
            }

            value = value.Replace("_", " ");
            value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            value = value.Replace(" ", "");

            return value;
        }

        public static string ToPluralEntity(this string value)
        {
            if (value[0] == '_')
            {
                value = value.Substring(1);
            }

            value = value.Replace("_", " ");
            value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            PluralizationServiceInstance ps = new PluralizationServiceInstance();
            value = ps.Pluralize(value);
            value = value.Replace(" ", "");

            return value;
        }

        #endregion

        #region enum naming

        public static string ToEnumName(this string value)
        {
            if (value[0] == '_')
            {
                value = value.Substring(1);
            }

            value = value.Replace("_", " ");
            value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            value = value.Replace(" ", "");
            return value;
        }

        #endregion

        #region Number to Human (short, int, long)

        private static readonly string[] UnitsMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private static readonly string[] TensMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public static string ToReadable(this short value) => ((int)value).ToReadable();

        public static string ToReadable(this int value) => ((long)value).ToReadable();

        public static string ToReadable(this long value)
        {
            if (value == 0)
            {
                return "Zero";
            }

            if (value < 0)
            {
                return $"Minus{ToReadable(-value)}";
            }

            List<string> parts = new List<string>();

            if (value / 1000000000000000 > 0)
            {
                parts.Add($"{ToReadable(value / 1000000000000000)}Quadrillion");
                value %= 1000000000000000;
            }

            if (value / 1000000000000 > 0)
            {
                parts.Add($"{ToReadable(value / 1000000000000)}Trillion");
                value %= 1000000000000;
            }

            if (value / 1000000000 > 0)
            {
                parts.Add($"{ToReadable(value / 1000000000)}Billion");
                value %= 1000000000;
            }

            if (value / 1000000 > 0)
            {
                parts.Add($"{ToReadable(value / 1000000)}Million");
                value %= 1000000;
            }

            if (value / 1000 > 0)
            {
                parts.Add($"{ToReadable(value / 1000)}Thousand");
                value %= 1000;
            }

            if (value / 100 > 0)
            {
                parts.Add($"{ToReadable(value / 100)}Hundred");
                value %= 100;
            }

            if (value > 0)
            {
                if (parts.Count != 0)
                {
                    parts.Add("And");
                }

                if (value < 20)
                {
                    parts.Add(UnitsMap[value]);
                }
                else
                {
                    string lastPart = TensMap[value / 10];
                    if (value % 10 > 0)
                    {
                        lastPart += $"{UnitsMap[value % 10]}";
                    }

                    parts.Add(lastPart);
                }
            }

            return string.Join("", parts.ToArray());
        }

        public static string NumberToReadable(this string value) => long.Parse(value).ToReadable();

        #endregion

        #region Db Naming

        public static string FromDbName(this string name)
        {
            switch (name.Substring(0, 3).ToLower())
            {
                case "arc":
                    return "Archive";

                case "cop":
                    return "Cop";

                case "int":
                    return "Interface";

                case "log":
                    return "Log";

                case "mas":
                    return "Master";

                case "met":
                    return "Meta";

                case "rep":
                    switch (name.Substring(0, 4).ToLower())
                    {
                        case "repo":
                            return "Report";

                        case "repl":
                            return "Replication";
                    }
                    break;

                case "sop":
                    return "Sop";
            }

            return string.Empty;
        }

        #endregion

        #region Db Types

        public static string ConvertDataType(this string type, bool isNullable)
        {
            string newval;
            bool ignoreNullableType = false;
            switch (type.ToLower())
            {
                case "money":
                case "decimal":
                case "numeric":
                    newval = "decimal";
                    break;

                case "float":
                    newval = "double";
                    break;

                case "int":
                    newval = "int";
                    break;

                case "bigint":
                    newval = "long";
                    break;

                case "varchar":
                case "nvarchar":
                case "ntext":
                case "text":
                case "char":
                case "nchar":
                    newval = "string";
                    ignoreNullableType = true;
                    break;

                case "date":
                case "datetime":
                    newval = "DateTime";
                    break;

                case "uniqueidentifier":
                    newval = "Guid";
                    break;

                case "image":
                case "varbinary":
                    newval = "byte[]";
                    ignoreNullableType = true;
                    break;

                case "bit":
                    newval = "bool";
                    break;

                default:
                    throw new StrongTypingException(type + " not found.");
            }

            if (isNullable && !ignoreNullableType)
            {
                newval += "?";
            }

            return newval;
        }

        #endregion
    }

    public class PluralizationServiceInstance : IPluralizer
    {
        private static readonly IPluralizationApi Api;
        private static readonly CultureInfo CultureInfo;

        static PluralizationServiceInstance()
        {
            PluralizationApiBuilder builder = new PluralizationApiBuilder();
            builder.AddEnglishProvider();

            Api = builder.Build();
            CultureInfo = new CultureInfo("en-US");
        }

        public string Pluralize(string name) => Api.Pluralize(name, CultureInfo) ?? name;

        public string Singularize(string name) => Api.Singularize(name, CultureInfo) ?? name;
    }
}