using System.ComponentModel.DataAnnotations.Schema;
using Enums = PKMDS_Enums.Enums;

namespace VeekunHelper
{
    public class Ability
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("is_main_series")]
        public bool IsMainSeries
        {
            get; set;
        }
    }

    public class AbilityChangelog
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("ability_id")]
        public long AbilityId
        {
            get; set;
        }

        [Column("changed_in_version_group_id")]
        public long ChangedInVersionGroupId
        {
            get; set;
        }
    }

    public class AbilityChangelogProse
    {
        [Column("ability_changelog_id")]
        public long AbilityChangelogId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class AbilityFlavorText
    {
        [Column("ability_id")]
        public long AbilityId
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("language_id")]
        public Enums.Languages LanguageId
        {
            get; set;
        }

        [Column("flavor_text")]
        public string? FlavorText
        {
            get; set;
        }
    }

    public class AbilityName
    {
        [Column("ability_id")]
        public long AbilityId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class AbilityProse
    {
        [Column("ability_id")]
        public long AbilityId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("short_effect")]
        public string? ShortEffect
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class Berry
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("firmness_id")]
        public long FirmnessId
        {
            get; set;
        }

        [Column("natural_gift_power")]
        public long NaturalGiftPower
        {
            get; set;
        }

        [Column("natural_gift_type_id")]
        public long NaturalGiftTypeId
        {
            get; set;
        }

        [Column("size")]
        public long Size
        {
            get; set;
        }

        [Column("max_harvest")]
        public long MaxHarvest
        {
            get; set;
        }

        [Column("growth_time")]
        public long GrowthTime
        {
            get; set;
        }

        [Column("soil_dryness")]
        public long SoilDryness
        {
            get; set;
        }

        [Column("smoothness")]
        public long Smoothness
        {
            get; set;
        }
    }

    public class BerryFirmness
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class BerryFirmnessName
    {
        [Column("berry_firmness_id")]
        public long BerryFirmnessId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class BerryFlavor
    {
        [Column("berry_id")]
        public long BerryId
        {
            get; set;
        }

        [Column("contest_type_id")]
        public long ContestTypeId
        {
            get; set;
        }

        [Column("flavor")]
        public long Flavor
        {
            get; set;
        }
    }

    public class CharacteristicText
    {
        [Column("characteristic_id")]
        public long CharacteristicId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("message")]
        public string? Message
        {
            get; set;
        }
    }

    public class Characteristic
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("stat_id")]
        public long StatId
        {
            get; set;
        }

        [Column("gene_mod_5")]
        public long GeneMod5
        {
            get; set;
        }
    }

    public class ConquestEpisodeName
    {
        [Column("episode_id")]
        public long EpisodeId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ConquestEpisodeWarrior
    {
        [Column("episode_id")]
        public long EpisodeId
        {
            get; set;
        }

        [Column("warrior_id")]
        public long WarriorId
        {
            get; set;
        }
    }

    public class ConquestEpisode
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class ConquestKingdomName
    {
        [Column("kingdom_id")]
        public long KingdomId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ConquestKingdom
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("type_id")]
        public long TypeId
        {
            get; set;
        }
    }

    public class ConquestMaxLink
    {
        [Column("warrior_rank_id")]
        public long WarriorRankId
        {
            get; set;
        }

        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }

        [Column("max_link")]
        public long MaxLink
        {
            get; set;
        }
    }

    public class ConquestMoveDatum
    {
        [Column("move_id")]
        public long MoveId
        {
            get; set;
        }

        [Column("power")]
        public long Power
        {
            get; set;
        }

        [Column("accuracy")]
        public long Accuracy
        {
            get; set;
        }

        [Column("effect_chance")]
        public long EffectChance
        {
            get; set;
        }

        [Column("effect_id")]
        public long EffectId
        {
            get; set;
        }

        [Column("range_id")]
        public long RangeId
        {
            get; set;
        }

        [Column("displacement_id")]
        public long DisplacementId
        {
            get; set;
        }
    }

    public class ConquestMoveDisplacementProse
    {
        [Column("move_displacement_id")]
        public long MoveDisplacementId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("short_effect")]
        public string? ShortEffect
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class ConquestMoveDisplacement
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("affects_target")]
        public bool AffectsTarget
        {
            get; set;
        }
    }

    public class ConquestMoveEffectProse
    {
        [Column("conquest_move_effect_id")]
        public long ConquestMoveEffectId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("short_effect")]
        public string? ShortEffect
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class ConquestMoveEffect
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }
    }

    public class ConquestMoveRangeProse
    {
        [Column("conquest_move_range_id")]
        public long ConquestMoveRangeId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class ConquestMoveRange
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("targets")]
        public long Target
        {
            get; set;
        }
    }

    public class ConquestPokemonAbility
    {
        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }

        [Column("slot")]
        public long Slot
        {
            get; set;
        }

        [Column("ability_id")]
        public long AbilityId
        {
            get; set;
        }
    }

    public class ConquestPokemonEvolution
    {
        [Column("evolved_species_id")]
        public Enums.Species EvolvedSpeciesId
        {
            get; set;
        }

        [Column("required_stat_id")]
        public long RequiredStatId
        {
            get; set;
        }

        [Column("minimum_stat")]
        public long MinimumStat
        {
            get; set;
        }

        [Column("minimum_link")]
        public long MinimumLink
        {
            get; set;
        }

        [Column("kingdom_id")]
        public long KingdomId
        {
            get; set;
        }

        [Column("warrior_gender_id")]
        public long WarriorGenderId
        {
            get; set;
        }

        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("recruiting_ko_required")]
        public bool RecruitingKoRequired
        {
            get; set;
        }
    }

    public class ConquestPokemonMove
    {
        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }

        [Column("move_id")]
        public long MoveId
        {
            get; set;
        }
    }

    public class ConquestPokemonStat
    {
        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }

        [Column("conquest_stat_id")]
        public long ConquestStatId
        {
            get; set;
        }

        [Column("base_stat")]
        public long BaseStat
        {
            get; set;
        }
    }

    public class ConquestStatName
    {
        [Column("conquest_stat_id")]
        public long ConquestStatId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ConquestStat
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("is_base")]
        public bool IsBase
        {
            get; set;
        }
    }

    public class ConquestTransformationPokemon
    {
        [Column("transformation_id")]
        public long TransformationId
        {
            get; set;
        }

        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }
    }

    public class ConquestTransformationWarrior
    {
        [Column("transformation_id")]
        public long TransformationId
        {
            get; set;
        }

        [Column("present_warrior_id")]
        public long PresentWarriorId
        {
            get; set;
        }
    }

    public class ConquestWarriorArchetype
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class ConquestWarriorName
    {
        [Column("warrior_id")]
        public long WarriorId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ConquestWarriorRankStatMap
    {
        [Column("warrior_rank_id")]
        public long WarriorRankId
        {
            get; set;
        }

        [Column("warrior_stat_id")]
        public long WarriorStatId
        {
            get; set;
        }

        [Column("base_stat")]
        public long BaseStat
        {
            get; set;
        }
    }

    public class ConquestWarriorRank
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("warrior_id")]
        public long WarriorId
        {
            get; set;
        }

        [Column("rank")]
        public long Rank
        {
            get; set;
        }

        [Column("skill_id")]
        public long SkillId
        {
            get; set;
        }
    }

    public class ConquestWarriorSkillName
    {
        [Column("skill_id")]
        public long SkillId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ConquestWarriorSkill
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class ConquestWarriorSpecialty
    {
        [Column("warrior_id")]
        public long WarriorId
        {
            get; set;
        }

        [Column("type_id")]
        public long TypeId
        {
            get; set;
        }

        [Column("slot")]
        public long Slot
        {
            get; set;
        }
    }

    public class ConquestWarriorStatName
    {
        [Column("warrior_stat_id")]
        public long WarriorStatId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ConquestWarriorStat
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class ConquestWarriorTransformation
    {
        [Column("transformed_warrior_rank_id")]
        public long TransformedWarriorRankId
        {
            get; set;
        }

        [Column("is_automatic")]
        public bool IsAutomatic
        {
            get; set;
        }

        [Column("required_link")]
        public long RequiredLink
        {
            get; set;
        }

        [Column("completed_episode_id")]
        public long CompletedEpisodeId
        {
            get; set;
        }

        [Column("current_episode_id")]
        public long CurrentEpisodeId
        {
            get; set;
        }

        [Column("distant_warrior_id")]
        public long DistantWarriorId
        {
            get; set;
        }

        [Column("female_warlord_count")]
        public long FemaleWarlordCount
        {
            get; set;
        }

        [Column("pokemon_count")]
        public long PokemonCount
        {
            get; set;
        }

        [Column("collection_type_id")]
        public long CollectionTypeId
        {
            get; set;
        }

        [Column("warrior_count")]
        public long WarriorCount
        {
            get; set;
        }
    }

    public class ConquestWarrior
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("gender_id")]
        public long GenderId
        {
            get; set;
        }

        [Column("archetype_id")]
        public long ArchetypeId
        {
            get; set;
        }
    }

    public class ContestCombo
    {
        [Column("first_move_id")]
        public Enums.Moves FirstMoveId
        {
            get; set;
        }

        [Column("second_move_id")]
        public Enums.Moves SecondMoveId
        {
            get; set;
        }
    }

    public class ContestEffectProse
    {
        [Column("contest_effect_id")]
        public long ContestEffectId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("flavor_text")]
        public string? FlavorText
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class ContestEffect
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("appeal")]
        public short Appeal
        {
            get; set;
        }

        [Column("jam")]
        public short Jam
        {
            get; set;
        }
    }

    public class ContestTypeName
    {
        [Column("contest_type_id")]
        public long ContestTypeId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("flavor")]
        public string? Flavor
        {
            get; set;
        }

        [Column("color")]
        public string? Color
        {
            get; set;
        }
    }

    public class ContestType
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class EggGroupProse
    {
        [Column("egg_group_id")]
        public long EggGroupId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class EggGroup
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class EncounterConditionProse
    {
        [Column("encounter_condition_id")]
        public long EncounterConditionId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class EncounterConditionValueMap
    {
        [Column("encounter_id")]
        public long EncounterId
        {
            get; set;
        }

        [Column("encounter_condition_value_id")]
        public long EncounterConditionValueId
        {
            get; set;
        }
    }

    public class EncounterConditionValueProse
    {
        [Column("encounter_condition_value_id")]
        public long EncounterConditionValueId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class EncounterConditionValue
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("encounter_condition_id")]
        public long EncounterConditionId
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("is_default")]
        public bool IsDefault
        {
            get; set;
        }
    }

    public class EncounterCondition
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class EncounterMethodProse
    {
        [Column("encounter_method_id")]
        public long EncounterMethodId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class EncounterMethod
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("order")]
        public long Order
        {
            get; set;
        }
    }

    public class EncounterSlot
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("encounter_method_id")]
        public long EncounterMethodId
        {
            get; set;
        }

        [Column("slot")]
        public long Slot
        {
            get; set;
        }

        [Column("rarity")]
        public long Rarity
        {
            get; set;
        }
    }

    public class Encounter
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("version_id")]
        public long VersionId
        {
            get; set;
        }

        [Column("location_area_id")]
        public long LocationAreaId
        {
            get; set;
        }

        [Column("encounter_slot_id")]
        public long EncounterSlotId
        {
            get; set;
        }

        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("min_level")]
        public long MinLevel
        {
            get; set;
        }

        [Column("max_level")]
        public long MaxLevel
        {
            get; set;
        }
    }

    public class EvolutionChain
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("baby_trigger_item_id")]
        public long BabyTriggerItemId
        {
            get; set;
        }
    }

    public class EvolutionTriggerProse
    {
        [Column("evolution_trigger_id")]
        public long EvolutionTriggerId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class EvolutionTrigger
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class Experience
    {
        [Column("growth_rate_id")]
        public long GrowthRateId
        {
            get; set;
        }

        [Column("level")]
        public long Level
        {
            get; set;
        }

        [Column("experience")]
        public long ExperienceValue
        {
            get; set;
        }
    }

    public class Gender
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class GenerationName
    {
        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class Generation
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("main_region_id")]
        public long MainRegionId
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class GrowthRateProse
    {
        [Column("growth_rate_id")]
        public long GrowthRateId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class GrowthRate
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("formula")]
        public string? Formula
        {
            get; set;
        }
    }

    public class ItemCategory
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("pocket_id")]
        public long PocketId
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class ItemCategoryProse
    {
        [Column("item_category_id")]
        public long ItemCategoryId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ItemFlagMap
    {
        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("item_flag_id")]
        public long ItemFlagId
        {
            get; set;
        }
    }

    public class ItemFlagProse
    {
        [Column("item_flag_id")]
        public long ItemFlagId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class ItemFlag
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class ItemFlavorSummary
    {
        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("flavor_summary")]
        public string? FlavorSummary
        {
            get; set;
        }
    }

    public class ItemFlavorText
    {
        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("language_id")]
        public Enums.Languages LanguageId
        {
            get; set;
        }

        [Column("flavor_text")]
        public string? FlavorText
        {
            get; set;
        }
    }

    public class ItemFlingEffectProse
    {
        [Column("item_fling_effect_id")]
        public long ItemFlingEffectId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class ItemFlingEffect
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }
    }

    public class ItemGameIndex
    {
        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }
    }

    public class ItemName
    {
        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ItemPocketName
    {
        [Column("item_pocket_id")]
        public long ItemPocketId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class ItemPocket
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class ItemProse
    {
        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("short_effect")]
        public string? ShortEffect
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class Item
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("category_id")]
        public long CategoryId
        {
            get; set;
        }

        [Column("cost")]
        public long Cost
        {
            get; set;
        }

        [Column("fling_power")]
        public long FlingPower
        {
            get; set;
        }

        [Column("fling_effect_id")]
        public long FlingEffectId
        {
            get; set;
        }
    }

    public class LanguageName
    {
        [Column("language_id")]
        public Enums.Languages LanguageId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class Language
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("iso639")]
        public string? Iso639
        {
            get; set;
        }

        [Column("iso3166")]
        public string? Iso3166
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("official")]
        public bool Official
        {
            get; set;
        }

        [Column("order")]
        public long Order
        {
            get; set;
        }
    }

    public class LocationAreaEncounterRate
    {
        [Column("location_area_id")]
        public long LocationAreaId
        {
            get; set;
        }

        [Column("encounter_method_id")]
        public long EncounterMethodId
        {
            get; set;
        }

        [Column("version_id")]
        public long VersionId
        {
            get; set;
        }

        [Column("rate")]
        public long Rate
        {
            get; set;
        }
    }

    public class LocationAreaProse
    {
        [Column("location_area_id")]
        public long LocationAreaId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class LocationArea
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("location_id")]
        public long LocationId
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class LocationGameIndex
    {
        [Column("location_id")]
        public long LocationId
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }
    }

    public class LocationName
    {
        [Column("location_id")]
        public long LocationId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class Location
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("region_id")]
        public long RegionId
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class Machine
    {
        [Column("machine_number")]
        public long MachineNumber
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }
    }

    public class MoveBattleStyleProse
    {
        [Column("move_battle_style_id")]
        public long MoveBattleStyleId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class MoveBattleStyle
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class MoveChangelog
    {
        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("changed_in_version_group_id")]
        public long ChangedInVersionGroupId
        {
            get; set;
        }

        [Column("type_id")]
        public long TypeId
        {
            get; set;
        }

        [Column("power")]
        public short Power
        {
            get; set;
        }

        [Column("pp")]
        public short Pp
        {
            get; set;
        }

        [Column("accuracy")]
        public short Accuracy
        {
            get; set;
        }

        [Column("priority")]
        public short Priority
        {
            get; set;
        }

        [Column("target_id")]
        public long TargetId
        {
            get; set;
        }

        [Column("effect_id")]
        public long EffectId
        {
            get; set;
        }

        [Column("effect_chance")]
        public long EffectChance
        {
            get; set;
        }
    }

    public class MoveDamageClassProse
    {
        [Column("move_damage_class_id")]
        public long MoveDamageClassId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class MoveDamageClass
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class MoveEffectChangelog
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("effect_id")]
        public long EffectId
        {
            get; set;
        }

        [Column("changed_in_version_group_id")]
        public long ChangedInVersionGroupId
        {
            get; set;
        }
    }

    public class MoveEffectChangelogProse
    {
        [Column("move_effect_changelog_id")]
        public long MoveEffectChangelogId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class MoveEffectProse
    {
        [Column("move_effect_id")]
        public long MoveEffectId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("short_effect")]
        public string? ShortEffect
        {
            get; set;
        }

        [Column("effect")]
        public string? Effect
        {
            get; set;
        }
    }

    public class MoveEffect
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }
    }

    public class MoveFlagMap
    {
        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("move_flag_id")]
        public long MoveFlagId
        {
            get; set;
        }
    }

    public class MoveFlagProse
    {
        [Column("move_flag_id")]
        public long MoveFlagId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class MoveFlag
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class MoveFlavorSummary
    {
        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("flavor_summary")]
        public string? FlavorSummary
        {
            get; set;
        }
    }

    public class MoveFlavorText
    {
        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("language_id")]
        public Enums.Languages LanguageId
        {
            get; set;
        }

        [Column("flavor_text")]
        public string? FlavorText
        {
            get; set;
        }
    }

    public class MoveMeta
    {
        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("meta_category_id")]
        public long MetaCategoryId
        {
            get; set;
        }

        [Column("meta_ailment_id")]
        public long MetaAilmentId
        {
            get; set;
        }

        [Column("min_hits")]
        public long MinHit
        {
            get; set;
        }

        [Column("max_hits")]
        public long MaxHit
        {
            get; set;
        }

        [Column("min_turns")]
        public long MinTurn
        {
            get; set;
        }

        [Column("max_turns")]
        public long MaxTurn
        {
            get; set;
        }

        [Column("drain")]
        public long Drain
        {
            get; set;
        }

        [Column("healing")]
        public long Healing
        {
            get; set;
        }

        [Column("crit_rate")]
        public long CritRate
        {
            get; set;
        }

        [Column("ailment_chance")]
        public long AilmentChance
        {
            get; set;
        }

        [Column("flinch_chance")]
        public long FlinchChance
        {
            get; set;
        }

        [Column("stat_chance")]
        public long StatChance
        {
            get; set;
        }
    }

    public class MoveMetaAilmentName
    {
        [Column("move_meta_ailment_id")]
        public long MoveMetaAilmentId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class MoveMetaAilment
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class MoveMetaCategory
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class MoveMetaCategoryProse
    {
        [Column("move_meta_category_id")]
        public long MoveMetaCategoryId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class MoveMetaStatChange
    {
        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("stat_id")]
        public long StatId
        {
            get; set;
        }

        [Column("change")]
        public long Change
        {
            get; set;
        }
    }

    public class MoveName
    {
        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class MoveTargetProse
    {
        [Column("move_target_id")]
        public long MoveTargetId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class MoveTarget
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class Move
    {
        [Column("id")]
        public Enums.Moves Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("type_id")]
        public long TypeId
        {
            get; set;
        }

        [Column("power")]
        public short Power
        {
            get; set;
        }

        [Column("pp")]
        public short Pp
        {
            get; set;
        }

        [Column("accuracy")]
        public short Accuracy
        {
            get; set;
        }

        [Column("priority")]
        public short Priority
        {
            get; set;
        }

        [Column("target_id")]
        public long TargetId
        {
            get; set;
        }

        [Column("damage_class_id")]
        public long DamageClassId
        {
            get; set;
        }

        [Column("effect_id")]
        public long EffectId
        {
            get; set;
        }

        [Column("effect_chance")]
        public long EffectChance
        {
            get; set;
        }

        [Column("contest_type_id")]
        public long ContestTypeId
        {
            get; set;
        }

        [Column("contest_effect_id")]
        public long ContestEffectId
        {
            get; set;
        }

        [Column("super_contest_effect_id")]
        public long SuperContestEffectId
        {
            get; set;
        }
    }

    public class NatureBattleStylePreference
    {
        [Column("nature_id")]
        public long NatureId
        {
            get; set;
        }

        [Column("move_battle_style_id")]
        public long MoveBattleStyleId
        {
            get; set;
        }

        [Column("low_hp_preference")]
        public long LowHpPreference
        {
            get; set;
        }

        [Column("high_hp_preference")]
        public long HighHpPreference
        {
            get; set;
        }
    }

    public class NatureName
    {
        [Column("nature_id")]
        public long NatureId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class NaturePokeathlonStat
    {
        [Column("nature_id")]
        public long NatureId
        {
            get; set;
        }

        [Column("pokeathlon_stat_id")]
        public long PokeathlonStatId
        {
            get; set;
        }

        [Column("max_change")]
        public long MaxChange
        {
            get; set;
        }
    }

    public class Nature
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("decreased_stat_id")]
        public long DecreasedStatId
        {
            get; set;
        }

        [Column("increased_stat_id")]
        public long IncreasedStatId
        {
            get; set;
        }

        [Column("hates_flavor_id")]
        public long HatesFlavorId
        {
            get; set;
        }

        [Column("likes_flavor_id")]
        public long LikesFlavorId
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }
    }

    public class PalPark
    {
        [Column("species_id")]
        public Enums.Species SpeciesId
        {
            get; set;
        }

        [Column("area_id")]
        public long AreaId
        {
            get; set;
        }

        [Column("base_score")]
        public long BaseScore
        {
            get; set;
        }

        [Column("rate")]
        public long Rate
        {
            get; set;
        }
    }

    public class PalParkAreaName
    {
        [Column("pal_park_area_id")]
        public long PalParkAreaId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class PalParkArea
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class PokeathlonStatName
    {
        [Column("pokeathlon_stat_id")]
        public long PokeathlonStatId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class PokeathlonStat
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class PokedexProse
    {
        [Column("pokedex_id")]
        public long PokedexId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class PokedexVersionGroup
    {
        [Column("pokedex_id")]
        public long PokedexId
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }
    }

    public class Pokedex
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("region_id")]
        public long RegionId
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("is_main_series")]
        public bool IsMainSeries
        {
            get; set;
        }
    }

    public class Pokemon
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("species_id")]
        public Enums.Species SpeciesId
        {
            get; set;
        }

        [Column("height")]
        public long Height
        {
            get; set;
        }

        [Column("weight")]
        public long Weight
        {
            get; set;
        }

        [Column("base_experience")]
        public long BaseExperience
        {
            get; set;
        }

        [Column("order")]
        public long Order
        {
            get; set;
        }

        [Column("is_default")]
        public bool IsDefault
        {
            get; set;
        }
    }

    public class PokemonAbility
    {
        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("ability_id")]
        public long AbilityId
        {
            get; set;
        }

        [Column("is_hidden")]
        public bool IsHidden
        {
            get; set;
        }

        [Column("slot")]
        public long Slot
        {
            get; set;
        }
    }

    public class PokemonColorName
    {
        [Column("pokemon_color_id")]
        public long PokemonColorId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class PokemonColor
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class PokemonDexNumber
    {
        [Column("species_id")]
        public Enums.Species SpeciesId
        {
            get; set;
        }

        [Column("pokedex_id")]
        public long PokedexId
        {
            get; set;
        }

        [Column("pokedex_number")]
        public long PokedexNumber
        {
            get; set;
        }
    }

    public class PokemonEggGroup
    {
        [Column("species_id")]
        public Enums.Species SpeciesId
        {
            get; set;
        }

        [Column("egg_group_id")]
        public long EggGroupId
        {
            get; set;
        }
    }

    public class PokemonEvolution
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("evolved_species_id")]
        public Enums.Species EvolvedSpeciesId
        {
            get; set;
        }

        [Column("evolution_trigger_id")]
        public long EvolutionTriggerId
        {
            get; set;
        }

        [Column("trigger_item_id")]
        public long TriggerItemId
        {
            get; set;
        }

        [Column("minimum_level")]
        public long MinimumLevel
        {
            get; set;
        }

        [Column("gender_id")]
        public long GenderId
        {
            get; set;
        }

        [Column("location_id")]
        public long LocationId
        {
            get; set;
        }

        [Column("held_item_id")]
        public long HeldItemId
        {
            get; set;
        }

        [Column("time_of_day")]
        public string? TimeOfDay
        {
            get; set;
        }

        [Column("known_move_id")]
        public Enums.Moves KnownMoveId
        {
            get; set;
        }

        [Column("known_move_type_id")]
        public long KnownMoveTypeId
        {
            get; set;
        }

        [Column("minimum_happiness")]
        public long MinimumHappiness
        {
            get; set;
        }

        [Column("minimum_beauty")]
        public long MinimumBeauty
        {
            get; set;
        }

        [Column("minimum_affection")]
        public long MinimumAffection
        {
            get; set;
        }

        [Column("relative_physical_stats")]
        public long RelativePhysicalStat
        {
            get; set;
        }

        [Column("party_species_id")]
        public Enums.Species PartySpeciesId
        {
            get; set;
        }

        [Column("party_type_id")]
        public Enums.Species PartyTypeId
        {
            get; set;
        }

        [Column("trade_species_id")]
        public Enums.Species TradeSpeciesId
        {
            get; set;
        }

        [Column("needs_overworld_rain")]
        public bool NeedsOverworldRain
        {
            get; set;
        }

        [Column("turn_upside_down")]
        public bool TurnUpsideDown
        {
            get; set;
        }
    }

    public class PokemonFormGeneration
    {
        [Column("pokemon_form_id")]
        public long PokemonFormId
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }
    }

    public class PokemonFormName
    {
        [Column("pokemon_form_id")]
        public long PokemonFormId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("form_name")]
        public string? FormName
        {
            get; set;
        }

        [Column("pokemon_name")]
        public string? PokemonName
        {
            get; set;
        }
    }

    public class PokemonFormPokeathlonStat
    {
        [Column("pokemon_form_id")]
        public long PokemonFormId
        {
            get; set;
        }

        [Column("pokeathlon_stat_id")]
        public long PokeathlonStatId
        {
            get; set;
        }

        [Column("minimum_stat")]
        public long MinimumStat
        {
            get; set;
        }

        [Column("base_stat")]
        public long BaseStat
        {
            get; set;
        }

        [Column("maximum_stat")]
        public long MaximumStat
        {
            get; set;
        }
    }

    public class PokemonForm
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("form_identifier")]
        public string? FormIdentifier
        {
            get; set;
        }

        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("introduced_in_version_group_id")]
        public long IntroducedInVersionGroupId
        {
            get; set;
        }

        [Column("is_default")]
        public bool IsDefault
        {
            get; set;
        }

        [Column("is_battle_only")]
        public bool IsBattleOnly
        {
            get; set;
        }

        [Column("is_mega")]
        public bool IsMega
        {
            get; set;
        }

        [Column("form_order")]
        public long FormOrder
        {
            get; set;
        }

        [Column("order")]
        public long Order
        {
            get; set;
        }
    }

    public class PokemonGameIndex
    {
        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("version_id")]
        public long VersionId
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }
    }

    public class PokemonHabitatName
    {
        [Column("pokemon_habitat_id")]
        public long PokemonHabitatId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class PokemonHabitat
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class PokemonItem
    {
        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("version_id")]
        public long VersionId
        {
            get; set;
        }

        [Column("item_id")]
        public long ItemId
        {
            get; set;
        }

        [Column("rarity")]
        public long Rarity
        {
            get; set;
        }
    }

    public class PokemonMoveMethodProse
    {
        [Column("pokemon_move_method_id")]
        public long PokemonMoveMethodId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class PokemonMoveMethod
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class PokemonMove
    {
        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("move_id")]
        public Enums.Moves MoveId
        {
            get; set;
        }

        [Column("pokemon_move_method_id")]
        public long PokemonMoveMethodId
        {
            get; set;
        }

        [Column("level")]
        public long Level
        {
            get; set;
        }

        [Column("order")]
        public long Order
        {
            get; set;
        }
    }

    public class PokemonShapeProse
    {
        [Column("pokemon_shape_id")]
        public long PokemonShapeId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("awesome_name")]
        public string? AwesomeName
        {
            get; set;
        }

        [Column("description")]
        public string? Description
        {
            get; set;
        }
    }

    public class PokemonShape
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class PokemonSpecies
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("evolves_from_species_id")]
        public Enums.Species EvolvesFromSpeciesId
        {
            get; set;
        }

        [Column("evolution_chain_id")]
        public long EvolutionChainId
        {
            get; set;
        }

        [Column("color_id")]
        public long ColorId
        {
            get; set;
        }

        [Column("shape_id")]
        public long ShapeId
        {
            get; set;
        }

        [Column("habitat_id")]
        public long HabitatId
        {
            get; set;
        }

        [Column("gender_rate")]
        public long GenderRate
        {
            get; set;
        }

        [Column("capture_rate")]
        public long CaptureRate
        {
            get; set;
        }

        [Column("base_happiness")]
        public long BaseHappiness
        {
            get; set;
        }

        [Column("is_baby")]
        public bool IsBaby
        {
            get; set;
        }

        [Column("hatch_counter")]
        public long HatchCounter
        {
            get; set;
        }

        [Column("has_gender_differences")]
        public bool HasGenderDifference
        {
            get; set;
        }

        [Column("growth_rate_id")]
        public long GrowthRateId
        {
            get; set;
        }

        [Column("forms_switchable")]
        public bool FormsSwitchable
        {
            get; set;
        }

        [Column("order")]
        public long Order
        {
            get; set;
        }

        [Column("conquest_order")]
        public long ConquestOrder
        {
            get; set;
        }
    }

    public class PokemonSpeciesFlavorSummary
    {
        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("flavor_summary")]
        public string? FlavorSummary
        {
            get; set;
        }
    }

    public class PokemonSpeciesFlavorText
    {
        [Column("species_id")]
        public Enums.Species SpeciesId
        {
            get; set;
        }

        [Column("version_id")]
        public long VersionId
        {
            get; set;
        }

        [Column("language_id")]
        public Enums.Languages LanguageId
        {
            get; set;
        }

        [Column("flavor_text")]
        public string? FlavorText
        {
            get; set;
        }
    }

    public class PokemonSpeciesName
    {
        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }

        [Column("genus")]
        public string? Genus
        {
            get; set;
        }
    }

    public class PokemonSpeciesProse
    {
        [Column("pokemon_species_id")]
        public Enums.Species PokemonSpeciesId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("form_description")]
        public string? FormDescription
        {
            get; set;
        }
    }

    public class PokemonStat
    {
        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("stat_id")]
        public long StatId
        {
            get; set;
        }

        [Column("base_stat")]
        public long BaseStat
        {
            get; set;
        }

        [Column("effort")]
        public long Effort
        {
            get; set;
        }
    }

    public class PokemonType
    {
        [Column("pokemon_id")]
        public long PokemonId
        {
            get; set;
        }

        [Column("type_id")]
        public long TypeId
        {
            get; set;
        }

        [Column("slot")]
        public long Slot
        {
            get; set;
        }
    }

    public class RegionName
    {
        [Column("region_id")]
        public long RegionId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class Region
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }

    public class StatName
    {
        [Column("stat_id")]
        public long StatId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class Stat
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("damage_class_id")]
        public long DamageClassId
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("is_battle_only")]
        public bool IsBattleOnly
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }
    }

    public class SuperContestCombo
    {
        [Column("first_move_id")]
        public Enums.Moves FirstMoveId
        {
            get; set;
        }

        [Column("second_move_id")]
        public Enums.Moves SecondMoveId
        {
            get; set;
        }
    }

    public class SuperContestEffectProse
    {
        [Column("super_contest_effect_id")]
        public long SuperContestEffectId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("flavor_text")]
        public string? FlavorText
        {
            get; set;
        }
    }

    public class SuperContestEffect
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("appeal")]
        public short Appeal
        {
            get; set;
        }
    }

    public class TypeEfficacy
    {
        [Column("damage_type_id")]
        public long DamageTypeId
        {
            get; set;
        }

        [Column("target_type_id")]
        public long TargetTypeId
        {
            get; set;
        }

        [Column("damage_factor")]
        public long DamageFactor
        {
            get; set;
        }
    }

    public class TypeGameIndex
    {
        [Column("type_id")]
        public long TypeId
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("game_index")]
        public long GameIndex
        {
            get; set;
        }
    }

    public class TypeName
    {
        [Column("type_id")]
        public long TypeId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class Type
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("damage_class_id")]
        public long DamageClassId
        {
            get; set;
        }
    }

    public class VersionGroupPokemonMoveMethod
    {
        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("pokemon_move_method_id")]
        public long PokemonMoveMethodId
        {
            get; set;
        }
    }

    public class VersionGroupRegion
    {
        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("region_id")]
        public long RegionId
        {
            get; set;
        }
    }

    public class VersionGroup
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }

        [Column("generation_id")]
        public long GenerationId
        {
            get; set;
        }

        [Column("order")]
        public long Order
        {
            get; set;
        }
    }

    public class VersionName
    {
        [Column("version_id")]
        public long VersionId
        {
            get; set;
        }

        [Column("local_language_id")]
        public Enums.Languages LocalLanguageId
        {
            get; set;
        }

        [Column("name")]
        public string? Name
        {
            get; set;
        }
    }

    public class Version
    {
        [Column("id")]
        public long Id
        {
            get; set;
        }

        [Column("version_group_id")]
        public long VersionGroupId
        {
            get; set;
        }

        [Column("identifier")]
        public string? Identifier
        {
            get; set;
        }
    }
}