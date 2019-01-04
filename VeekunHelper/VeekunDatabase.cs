using Dapper;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using static PKMDS_Enums.Enums;

namespace VeekunHelper
{
    public static class VeekunDatabase
    {
        private const string DbName = @"C:\Users\mbond\Downloads\veekun-pokedex.sqlite\veekun-pokedex.sqlite";

        private static DataSet _veekunDataSet;

        public static DataSet VeekunDataSet
        {
            get
            {
                if (_veekunDataSet == null)
                {
                    GetAllData();
                }

                return _veekunDataSet;
            }
        }

        public static void GetAllData()
        {
            _veekunDataSet = new DataSet("veekun");
            using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={DbName};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = @"SELECT name FROM sqlite_master WHERE type = 'table' ORDER BY name";
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tableName = reader["name"].ToString();
                            DataTable table = new DataTable(tableName);
                            using (SQLiteCommand tableCommand = new SQLiteCommand(connection))
                            {
                                tableCommand.CommandText = $@"SELECT * FROM {tableName}";
                                using (SQLiteDataReader tableReader = tableCommand.ExecuteReader())
                                {
                                    table.Load(tableReader);
                                }
                            }

                            _veekunDataSet.Tables.Add(table);
                        }
                    }
                }

                connection.Close();
            }
        }

        private static void SetCustomTypeMap<T>() =>
            SqlMapper.SetTypeMap(typeof(T), new CustomPropertyTypeMap(typeof(T), (type, columnName) =>
                type.GetProperties()
                    .FirstOrDefault(prop => prop.GetCustomAttributes(false)
                        .OfType<ColumnAttribute>()
                        .Any(attr => attr.Name == columnName))));

        public static void TestDapper()
        {
            SetCustomTypeMap<PokemonSpeciesObject>();

            using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={DbName};Version=3;"))
            {
                const string sql = @"SELECT * FROM pokemon_species_names"; // WHERE pokemon_species_id = @SpeciesId AND local_language_id IN @Languages";
                object cmdParameters = new
                {
                    SpeciesId = Species.NidoranM,
                    Languages = new Languages[]
                    {
                        Languages.English,
                        Languages.Japanese,
                    },
                };

                var dynamicTest = connection.Query(sql/*, cmdParameters*/).Where(pkm => pkm.local_language_id == Languages.English);
                var classTest = connection.Query<PokemonSpeciesObject>(sql/*, cmdParameters*/).Where(pkm => pkm.LocalLanguage == Languages.English);
            }
        }
    }

    public class PokemonSpeciesObject
    {
        [Column("pokemon_species_id")]
        public Species PokemonSpecies
        {
            get; set;
        }

        [Column("local_language_id")]
        public Languages LocalLanguage
        {
            get; set;
        }

        [Column("name")]
        public string Name
        {
            get; set;
        }

        [Column("genus")]
        public string Genus
        {
            get; set;
        }
    }
}