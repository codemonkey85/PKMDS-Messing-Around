using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace PKMDS.Extensions
{
    public static class EnumExtension
    {
        public static string GetEnumDescription<T>(this T element) where T : Enum // needs C# 7.3
        {
            try
            {
                string elementString = element?.ToString();
                DescriptionAttribute[] descAttributes = element?.GetType().GetField(elementString)?.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                return descAttributes?.Length > 0 ? descAttributes[0].Description : elementString ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static IEnumerable<Tuple<T, string>> GetEnumValuesAndDescriptions<T>() where T : Enum // needs C# 7.3
        {
            foreach (T enumValue in Enum.GetValues(typeof(T)))
            {
                yield return new Tuple<T, string>(enumValue, enumValue.GetEnumDescription());
            }
        }

        public static T GetEnumFromDescription<T>(string desc) =>
            (T)new List<FieldInfo>(typeof(T).GetFields()).Find(new DescAttrFinder(desc).FindPredicate).GetRawConstantValue();

        private class DescAttrFinder
        {
            private readonly string _descAttributeValue;

            public DescAttrFinder(string descAttributeValue) => _descAttributeValue = descAttributeValue;

            public bool FindPredicate(FieldInfo fi) =>
                string.Compare(_descAttributeValue,
                    fi.GetCustomAttributes(typeof(DescriptionAttribute), false) is DescriptionAttribute[] descAttributes && descAttributes.Length > 0
                    ? descAttributes[0].Description
                    : null,
                    StringComparison.Ordinal) == 0;
        }
    }
}