using Dapper;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using VeekunHelper.Extensions;
using Enums = PKMDS_Enums.Enums;

namespace VeekunHelper
{
    public static class VeekunDatabase
    {
        private const string DbName = @"C:\Users\mbond\Downloads\veekun-pokedex.sqlite\veekun-pokedex.sqlite";
        private static bool _customTypeMapsSet;

        private static DataSet _veekunDataSet;

        public static DataSet VeekunDataSet
        {
            get
            {
                if (_veekunDataSet == null)
                {
                    FillVeekunDataSet();
                }

                return _veekunDataSet;
            }
        }

        private static SQLiteConnection _connection;

        private static SQLiteConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    SetConnection();
                }

                return _connection;
            }
        }

        private static void SetConnection()
        {
            SetAllCustomTypeMaps();
            _connection = new SQLiteConnection($@"Data Source={DbName};Version=3;");
        }

        private static void FillVeekunDataSet()
        {
            _veekunDataSet = new DataSet("veekun");
            using (IDataReader reader = Connection.ExecuteReader(
                @"SELECT name
                  FROM sqlite_master
                  WHERE type = 'table'
                  ORDER BY name"))
            {
                while (reader.Read())
                {
                    string tableName = reader["name"].ToString();
                    DataTable table = new DataTable(tableName);
                    using (IDataReader tableReader = Connection.ExecuteReader(
                        $@"SELECT *
                           FROM {tableName}"))
                    {
                        table.Load(tableReader);
                    }

                    _veekunDataSet.Tables.Add(table);
                }
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
            if (_customTypeMapsSet)
            {
                return;
            }
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
            _customTypeMapsSet = true;
        }

        public static dynamic TestDapper()
        {
            const string sql =
                @"SELECT
                  p.species_id,
                  p.identifier,
                  p.height,
                  p.weight,
                  p.base_experience,
                  p.[order],
                  p.is_default,
                  psn.name,
                  psn.local_language_id,
                  psn.genus,
                  (SELECT base_stat FROM pokemon_stats WHERE pokemon_id = p.id AND stat_id = @HpStat) AS hp_base_stat,
                  (SELECT base_stat FROM pokemon_stats WHERE pokemon_id = p.id AND stat_id = @AttackStat) AS attack_base_stat,
                  (SELECT base_stat FROM pokemon_stats WHERE pokemon_id = p.id AND stat_id = @DefenseStat) AS defense_base_stat,
                  (SELECT base_stat FROM pokemon_stats WHERE pokemon_id = p.id AND stat_id = @SpecialAttackStat) AS special_attack_base_stat,
                  (SELECT base_stat FROM pokemon_stats WHERE pokemon_id = p.id AND stat_id = @SpecialDefenseStat) AS special_defense_base_stat,
                  (SELECT base_stat FROM pokemon_stats WHERE pokemon_id = p.id AND stat_id = @SpeedStat) AS speed_base_stat
                  FROM pokemon p
                  INNER JOIN pokemon_species_names psn ON p.species_id = psn.pokemon_species_id";
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

            //var valueTupleResult = Connection.Query<Pokemon, PokemonSpeciesName, (Pokemon, PokemonSpeciesName)>(sql, (pokemon, pokemonSpeciesName) => (pokemon, pokemonSpeciesName), splitOn: "name").Where(p => p.Item2?.LocalLanguageId == Enums.Languages.English);
            //var dynamicResult = Connection.Query<Pokemon, PokemonSpeciesName, dynamic>(sql, (pokemon, pokemonSpeciesName) => (pokemon, pokemonSpeciesName), splitOn: "name").Where(p => p.Item2?.LocalLanguageId == Enums.Languages.English);

            return Connection.Query<Pokemon, PokemonSpeciesName, dynamic, dynamic>(sql, (pokemon, pokemonSpeciesName, pokemonStats) =>
                new
                {
                    //pokemon.SpeciesId,
                    pokemon.Identifier,
                    pokemon.Height,
                    pokemon.Weight,
                    pokemon.BaseExperience,
                    pokemon.Order,
                    pokemon.IsDefault,
                    pokemonSpeciesName?.Name,
                    pokemonSpeciesName?.LocalLanguageId,
                    pokemonSpeciesName?.Genus,
                    pokemonStats.hp_base_stat,
                    pokemonStats.attack_base_stat,
                    pokemonStats.defense_base_stat,
                    pokemonStats.special_attack_base_stat,
                    pokemonStats.special_defense_base_stat,
                    pokemonStats.speed_base_stat,
                }, param: new
                {
                    HpStat = 1,
                    AttackStat = 2,
                    DefenseStat = 3,
                    SpecialAttackStat = 4,
                    SpecialDefenseStat = 5,
                    SpeedStat = 6,
                }, splitOn: "name,hp_base_stat").Where(p => p?.LocalLanguageId == Enums.Languages.English);
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
            generatedPoCosStringBuilder.AppendLine("/*");
            generatedPoCosStringBuilder.AppendLine(setCustomTypeMapStringBuilder.ToString());
            generatedPoCosStringBuilder.AppendLine("*/");

            return generatedPoCosStringBuilder.ToString();

            string ConvertDbNameToProperName(string dbName)
            {
                return dbName.ToSingularEntity();
            }
        }
    }
}