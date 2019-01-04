using Dapper;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using VeekunHelper.Extensions;

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

        private static void SetAllCustomTypeMaps()
        {
            SetCustomTypeMap<Ability>();
            SetCustomTypeMap<AbilityChangelog>();
            SetCustomTypeMap<AbilityChangelogProse>();
            SetCustomTypeMap<AbilityFlavorText>();
            SetCustomTypeMap<AbilityName>();
            SetCustomTypeMap<AbilityProse>();
            SetCustomTypeMap<Berry>();
            SetCustomTypeMap<BerryFirmness>();
            SetCustomTypeMap<BerryFirmnessName>();
            SetCustomTypeMap<BerryFlavor>();
            SetCustomTypeMap<CharacteristicText>();
            SetCustomTypeMap<Characteristic>();
            SetCustomTypeMap<ConquestEpisodeName>();
            SetCustomTypeMap<ConquestEpisodeWarrior>();
            SetCustomTypeMap<ConquestEpisode>();
            SetCustomTypeMap<ConquestKingdomName>();
            SetCustomTypeMap<ConquestKingdom>();
            SetCustomTypeMap<ConquestMaxLink>();
            SetCustomTypeMap<ConquestMoveDatum>();
            SetCustomTypeMap<ConquestMoveDisplacementProse>();
            SetCustomTypeMap<ConquestMoveDisplacement>();
            SetCustomTypeMap<ConquestMoveEffectProse>();
            SetCustomTypeMap<ConquestMoveEffect>();
            SetCustomTypeMap<ConquestMoveRangeProse>();
            SetCustomTypeMap<ConquestMoveRange>();
            SetCustomTypeMap<ConquestPokemonAbility>();
            SetCustomTypeMap<ConquestPokemonEvolution>();
            SetCustomTypeMap<ConquestPokemonMove>();
            SetCustomTypeMap<ConquestPokemonStat>();
            SetCustomTypeMap<ConquestStatName>();
            SetCustomTypeMap<ConquestStat>();
            SetCustomTypeMap<ConquestTransformationPokemon>();
            SetCustomTypeMap<ConquestTransformationWarrior>();
            SetCustomTypeMap<ConquestWarriorArchetype>();
            SetCustomTypeMap<ConquestWarriorName>();
            SetCustomTypeMap<ConquestWarriorRankStatMap>();
            SetCustomTypeMap<ConquestWarriorRank>();
            SetCustomTypeMap<ConquestWarriorSkillName>();
            SetCustomTypeMap<ConquestWarriorSkill>();
            SetCustomTypeMap<ConquestWarriorSpecialty>();
            SetCustomTypeMap<ConquestWarriorStatName>();
            SetCustomTypeMap<ConquestWarriorStat>();
            SetCustomTypeMap<ConquestWarriorTransformation>();
            SetCustomTypeMap<ConquestWarrior>();
            SetCustomTypeMap<ContestCombo>();
            SetCustomTypeMap<ContestEffectProse>();
            SetCustomTypeMap<ContestEffect>();
            SetCustomTypeMap<ContestTypeName>();
            SetCustomTypeMap<ContestType>();
            SetCustomTypeMap<EggGroupProse>();
            SetCustomTypeMap<EggGroup>();
            SetCustomTypeMap<EncounterConditionProse>();
            SetCustomTypeMap<EncounterConditionValueMap>();
            SetCustomTypeMap<EncounterConditionValueProse>();
            SetCustomTypeMap<EncounterConditionValue>();
            SetCustomTypeMap<EncounterCondition>();
            SetCustomTypeMap<EncounterMethodProse>();
            SetCustomTypeMap<EncounterMethod>();
            SetCustomTypeMap<EncounterSlot>();
            SetCustomTypeMap<Encounter>();
            SetCustomTypeMap<EvolutionChain>();
            SetCustomTypeMap<EvolutionTriggerProse>();
            SetCustomTypeMap<EvolutionTrigger>();
            SetCustomTypeMap<Experience>();
            SetCustomTypeMap<Gender>();
            SetCustomTypeMap<GenerationName>();
            SetCustomTypeMap<Generation>();
            SetCustomTypeMap<GrowthRateProse>();
            SetCustomTypeMap<GrowthRate>();
            SetCustomTypeMap<ItemCategory>();
            SetCustomTypeMap<ItemCategoryProse>();
            SetCustomTypeMap<ItemFlagMap>();
            SetCustomTypeMap<ItemFlagProse>();
            SetCustomTypeMap<ItemFlag>();
            SetCustomTypeMap<ItemFlavorSummary>();
            SetCustomTypeMap<ItemFlavorText>();
            SetCustomTypeMap<ItemFlingEffectProse>();
            SetCustomTypeMap<ItemFlingEffect>();
            SetCustomTypeMap<ItemGameIndex>();
            SetCustomTypeMap<ItemName>();
            SetCustomTypeMap<ItemPocketName>();
            SetCustomTypeMap<ItemPocket>();
            SetCustomTypeMap<ItemProse>();
            SetCustomTypeMap<Item>();
            SetCustomTypeMap<LanguageName>();
            SetCustomTypeMap<Language>();
            SetCustomTypeMap<LocationAreaEncounterRate>();
            SetCustomTypeMap<LocationAreaProse>();
            SetCustomTypeMap<LocationArea>();
            SetCustomTypeMap<LocationGameIndex>();
            SetCustomTypeMap<LocationName>();
            SetCustomTypeMap<Location>();
            SetCustomTypeMap<Machine>();
            SetCustomTypeMap<MoveBattleStyleProse>();
            SetCustomTypeMap<MoveBattleStyle>();
            SetCustomTypeMap<MoveChangelog>();
            SetCustomTypeMap<MoveDamageClassProse>();
            SetCustomTypeMap<MoveDamageClass>();
            SetCustomTypeMap<MoveEffectChangelog>();
            SetCustomTypeMap<MoveEffectChangelogProse>();
            SetCustomTypeMap<MoveEffectProse>();
            SetCustomTypeMap<MoveEffect>();
            SetCustomTypeMap<MoveFlagMap>();
            SetCustomTypeMap<MoveFlagProse>();
            SetCustomTypeMap<MoveFlag>();
            SetCustomTypeMap<MoveFlavorSummary>();
            SetCustomTypeMap<MoveFlavorText>();
            SetCustomTypeMap<MoveMeta>();
            SetCustomTypeMap<MoveMetaAilmentName>();
            SetCustomTypeMap<MoveMetaAilment>();
            SetCustomTypeMap<MoveMetaCategory>();
            SetCustomTypeMap<MoveMetaCategoryProse>();
            SetCustomTypeMap<MoveMetaStatChange>();
            SetCustomTypeMap<MoveName>();
            SetCustomTypeMap<MoveTargetProse>();
            SetCustomTypeMap<MoveTarget>();
            SetCustomTypeMap<Move>();
            SetCustomTypeMap<NatureBattleStylePreference>();
            SetCustomTypeMap<NatureName>();
            SetCustomTypeMap<NaturePokeathlonStat>();
            SetCustomTypeMap<Nature>();
            SetCustomTypeMap<PalPark>();
            SetCustomTypeMap<PalParkAreaName>();
            SetCustomTypeMap<PalParkArea>();
            SetCustomTypeMap<PokeathlonStatName>();
            SetCustomTypeMap<PokeathlonStat>();
            SetCustomTypeMap<PokedexProse>();
            SetCustomTypeMap<PokedexVersionGroup>();
            SetCustomTypeMap<Pokedex>();
            SetCustomTypeMap<Pokemon>();
            SetCustomTypeMap<PokemonAbility>();
            SetCustomTypeMap<PokemonColorName>();
            SetCustomTypeMap<PokemonColor>();
            SetCustomTypeMap<PokemonDexNumber>();
            SetCustomTypeMap<PokemonEggGroup>();
            SetCustomTypeMap<PokemonEvolution>();
            SetCustomTypeMap<PokemonFormGeneration>();
            SetCustomTypeMap<PokemonFormName>();
            SetCustomTypeMap<PokemonFormPokeathlonStat>();
            SetCustomTypeMap<PokemonForm>();
            SetCustomTypeMap<PokemonGameIndex>();
            SetCustomTypeMap<PokemonHabitatName>();
            SetCustomTypeMap<PokemonHabitat>();
            SetCustomTypeMap<PokemonItem>();
            SetCustomTypeMap<PokemonMoveMethodProse>();
            SetCustomTypeMap<PokemonMoveMethod>();
            SetCustomTypeMap<PokemonMove>();
            SetCustomTypeMap<PokemonShapeProse>();
            SetCustomTypeMap<PokemonShape>();
            SetCustomTypeMap<PokemonSpecies>();
            SetCustomTypeMap<PokemonSpeciesFlavorSummary>();
            SetCustomTypeMap<PokemonSpeciesFlavorText>();
            SetCustomTypeMap<PokemonSpeciesName>();
            SetCustomTypeMap<PokemonSpeciesProse>();
            SetCustomTypeMap<PokemonStat>();
            SetCustomTypeMap<PokemonType>();
            SetCustomTypeMap<RegionName>();
            SetCustomTypeMap<Region>();
            SetCustomTypeMap<StatName>();
            SetCustomTypeMap<Stat>();
            SetCustomTypeMap<SuperContestCombo>();
            SetCustomTypeMap<SuperContestEffectProse>();
            SetCustomTypeMap<SuperContestEffect>();
            SetCustomTypeMap<TypeEfficacy>();
            SetCustomTypeMap<TypeGameIndex>();
            SetCustomTypeMap<TypeName>();
            SetCustomTypeMap<Type>();
            SetCustomTypeMap<VersionGroupPokemonMoveMethod>();
            SetCustomTypeMap<VersionGroupRegion>();
            SetCustomTypeMap<VersionGroup>();
            SetCustomTypeMap<VersionName>();
            SetCustomTypeMap<Version>();
        }

        public static void TestDapper()
        {
            SetAllCustomTypeMaps();

            using (SQLiteConnection connection = new SQLiteConnection($@"Data Source={DbName};Version=3;"))
            {
                //const string sql =
                //    @"SELECT
                //      p.identifier,
                //      p.height,
                //      p.weight,
                //      p.base_experience,
                //      p.[order],
                //      p.is_default,
                //      psn.name,
                //      psn.local_language_id,
                //      psn.genus
                //      FROM pokemon p
                //      INNER JOIN pokemon_species_names psn ON p.species_id = psn.pokemon_species_id";
                // WHERE pokemon_species_id = @SpeciesId AND local_language_id IN @Languages";
                //object cmdParameters = new
                //{
                //    SpeciesId = Species.NidoranM,
                //    Languages = new Languages[]
                //    {
                //        Languages.English,
                //        Languages.Japanese,
                //    },
                //};

                //var dynamicTest = connection.Query(sql).Where(pkm => pkm.local_language_id == (long)Languages.English).Take(151);
                //var classTest = connection.Query(sql).Where(pkm => pkm.LocalLanguage == Languages.English);

                var result = connection.Query<PokemonSpecies>(@"SELECT * FROM pokemon_species");
            }
        }

        public static string TestGeneratingPoCos()
        {
            StringBuilder generatedPoCosStringBuilder = new StringBuilder();
            StringBuilder setCustomTypeMapStringBuilder = new StringBuilder();

            foreach (DataTable dataTable in VeekunDataSet.Tables) // .AsEnumerable<DataTable>().Where(dt => dt.TableName == "" || dt.TableName = ""))
            {
                string className = ConvertDbNameToProperName(dataTable.TableName);
                setCustomTypeMapStringBuilder.AppendLine($"SetCustomTypeMap<{className}>();");
                generatedPoCosStringBuilder.AppendLine($"public class {className}");
                generatedPoCosStringBuilder.AppendLine("{");
                foreach (DataColumn column in dataTable.Columns)
                {
                    string fieldName = ConvertDbNameToProperName(column.ColumnName);
                    generatedPoCosStringBuilder.AppendLine($"\t[Column(\"{column.ColumnName}\")]");
                    generatedPoCosStringBuilder.AppendLine($"\tpublic {column.DataType} {fieldName} {{ get; set; }}");
                }
                generatedPoCosStringBuilder.AppendLine("}");
                generatedPoCosStringBuilder.AppendLine();
            }

            generatedPoCosStringBuilder.AppendLine();
            generatedPoCosStringBuilder.AppendLine(setCustomTypeMapStringBuilder.ToString());
            return generatedPoCosStringBuilder.ToString();

            string ConvertDbNameToProperName(string dbName)
            {
                return dbName.ToSingularEntity();
            }
        }
    }
}