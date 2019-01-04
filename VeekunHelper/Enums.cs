using System.Collections.Generic;
using System.ComponentModel;

// ReSharper disable UnusedMember.Global

namespace PKMDS_Enums
{
    public static class Enums
    {
        public enum Species : ushort
        {
            [Description("No Species")]
            NoSpecies = 0,

            [Description("Bulbasaur")]
            Bulbasaur = 1,

            [Description("Ivysaur")]
            Ivysaur = 2,

            [Description("Venusaur")]
            Venusaur = 3,

            [Description("Charmander")]
            Charmander = 4,

            [Description("Charmeleon")]
            Charmeleon = 5,

            [Description("Charizard")]
            Charizard = 6,

            [Description("Squirtle")]
            Squirtle = 7,

            [Description("Wartortle")]
            Wartortle = 8,

            [Description("Blastoise")]
            Blastoise = 9,

            [Description("Caterpie")]
            Caterpie = 10,

            [Description("Metapod")]
            Metapod = 11,

            [Description("Butterfree")]
            Butterfree = 12,

            [Description("Weedle")]
            Weedle = 13,

            [Description("Kakuna")]
            Kakuna = 14,

            [Description("Beedrill")]
            Beedrill = 15,

            [Description("Pidgey")]
            Pidgey = 16,

            [Description("Pidgeotto")]
            Pidgeotto = 17,

            [Description("Pidgeot")]
            Pidgeot = 18,

            [Description("Rattata")]
            Rattata = 19,

            [Description("Raticate")]
            Raticate = 20,

            [Description("Spearow")]
            Spearow = 21,

            [Description("Fearow")]
            Fearow = 22,

            [Description("Ekans")]
            Ekans = 23,

            [Description("Arbok")]
            Arbok = 24,

            [Description("Pikachu")]
            Pikachu = 25,

            [Description("Raichu")]
            Raichu = 26,

            [Description("Sandshrew")]
            Sandshrew = 27,

            [Description("Sandslash")]
            Sandslash = 28,

            [Description("Nidoran♀")]
            NidoranF = 29,

            [Description("Nidorina")]
            Nidorina = 30,

            [Description("Nidoqueen")]
            Nidoqueen = 31,

            [Description("Nidoran♂")]
            NidoranM = 32,

            [Description("Nidorino")]
            Nidorino = 33,

            [Description("Nidoking")]
            Nidoking = 34,

            [Description("Clefairy")]
            Clefairy = 35,

            [Description("Clefable")]
            Clefable = 36,

            [Description("Vulpix")]
            Vulpix = 37,

            [Description("Ninetales")]
            Ninetales = 38,

            [Description("Jigglypuff")]
            Jigglypuff = 39,

            [Description("Wigglytuff")]
            Wigglytuff = 40,

            [Description("Zubat")]
            Zubat = 41,

            [Description("Golbat")]
            Golbat = 42,

            [Description("Oddish")]
            Oddish = 43,

            [Description("Gloom")]
            Gloom = 44,

            [Description("Vileplume")]
            Vileplume = 45,

            [Description("Paras")]
            Paras = 46,

            [Description("Parasect")]
            Parasect = 47,

            [Description("Venonat")]
            Venonat = 48,

            [Description("Venomoth")]
            Venomoth = 49,

            [Description("Diglett")]
            Diglett = 50,

            [Description("Dugtrio")]
            Dugtrio = 51,

            [Description("Meowth")]
            Meowth = 52,

            [Description("Persian")]
            Persian = 53,

            [Description("Psyduck")]
            Psyduck = 54,

            [Description("Golduck")]
            Golduck = 55,

            [Description("Mankey")]
            Mankey = 56,

            [Description("Primeape")]
            Primeape = 57,

            [Description("Growlithe")]
            Growlithe = 58,

            [Description("Arcanine")]
            Arcanine = 59,

            [Description("Poliwag")]
            Poliwag = 60,

            [Description("Poliwhirl")]
            Poliwhirl = 61,

            [Description("Poliwrath")]
            Poliwrath = 62,

            [Description("Abra")]
            Abra = 63,

            [Description("Kadabra")]
            Kadabra = 64,

            [Description("Alakazam")]
            Alakazam = 65,

            [Description("Machop")]
            Machop = 66,

            [Description("Machoke")]
            Machoke = 67,

            [Description("Machamp")]
            Machamp = 68,

            [Description("Bellsprout")]
            Bellsprout = 69,

            [Description("Weepinbell")]
            Weepinbell = 70,

            [Description("Victreebel")]
            Victreebel = 71,

            [Description("Tentacool")]
            Tentacool = 72,

            [Description("Tentacruel")]
            Tentacruel = 73,

            [Description("Geodude")]
            Geodude = 74,

            [Description("Graveler")]
            Graveler = 75,

            [Description("Golem")]
            Golem = 76,

            [Description("Ponyta")]
            Ponyta = 77,

            [Description("Rapidash")]
            Rapidash = 78,

            [Description("Slowpoke")]
            Slowpoke = 79,

            [Description("Slowbro")]
            Slowbro = 80,

            [Description("Magnemite")]
            Magnemite = 81,

            [Description("Magneton")]
            Magneton = 82,

            [Description("Farfetch'd")]
            Farfetchd = 83,

            [Description("Doduo")]
            Doduo = 84,

            [Description("Dodrio")]
            Dodrio = 85,

            [Description("Seel")]
            Seel = 86,

            [Description("Dewgong")]
            Dewgong = 87,

            [Description("Grimer")]
            Grimer = 88,

            [Description("Muk")]
            Muk = 89,

            [Description("Shellder")]
            Shellder = 90,

            [Description("Cloyster")]
            Cloyster = 91,

            [Description("Gastly")]
            Gastly = 92,

            [Description("Haunter")]
            Haunter = 93,

            [Description("Gengar")]
            Gengar = 94,

            [Description("Onix")]
            Onix = 95,

            [Description("Drowzee")]
            Drowzee = 96,

            [Description("Hypno")]
            Hypno = 97,

            [Description("Krabby")]
            Krabby = 98,

            [Description("Kingler")]
            Kingler = 99,

            [Description("Voltorb")]
            Voltorb = 100,

            [Description("Electrode")]
            Electrode = 101,

            [Description("Exeggcute")]
            Exeggcute = 102,

            [Description("Exeggutor")]
            Exeggutor = 103,

            [Description("Cubone")]
            Cubone = 104,

            [Description("Marowak")]
            Marowak = 105,

            [Description("Hitmonlee")]
            Hitmonlee = 106,

            [Description("Hitmonchan")]
            Hitmonchan = 107,

            [Description("Lickitung")]
            Lickitung = 108,

            [Description("Koffing")]
            Koffing = 109,

            [Description("Weezing")]
            Weezing = 110,

            [Description("Rhyhorn")]
            Rhyhorn = 111,

            [Description("Rhydon")]
            Rhydon = 112,

            [Description("Chansey")]
            Chansey = 113,

            [Description("Tangela")]
            Tangela = 114,

            [Description("Kangaskhan")]
            Kangaskhan = 115,

            [Description("Horsea")]
            Horsea = 116,

            [Description("Seadra")]
            Seadra = 117,

            [Description("Goldeen")]
            Goldeen = 118,

            [Description("Seaking")]
            Seaking = 119,

            [Description("Staryu")]
            Staryu = 120,

            [Description("Starmie")]
            Starmie = 121,

            [Description("Mr. Mime")]
            MrMime = 122,

            [Description("Scyther")]
            Scyther = 123,

            [Description("Jynx")]
            Jynx = 124,

            [Description("Electabuzz")]
            Electabuzz = 125,

            [Description("Magmar")]
            Magmar = 126,

            [Description("Pinsir")]
            Pinsir = 127,

            [Description("Tauros")]
            Tauros = 128,

            [Description("Magikarp")]
            Magikarp = 129,

            [Description("Gyarados")]
            Gyarados = 130,

            [Description("Lapras")]
            Lapras = 131,

            [Description("Ditto")]
            Ditto = 132,

            [Description("Eevee")]
            Eevee = 133,

            [Description("Vaporeon")]
            Vaporeon = 134,

            [Description("Jolteon")]
            Jolteon = 135,

            [Description("Flareon")]
            Flareon = 136,

            [Description("Porygon")]
            Porygon = 137,

            [Description("Omanyte")]
            Omanyte = 138,

            [Description("Omastar")]
            Omastar = 139,

            [Description("Kabuto")]
            Kabuto = 140,

            [Description("Kabutops")]
            Kabutops = 141,

            [Description("Aerodactyl")]
            Aerodactyl = 142,

            [Description("Snorlax")]
            Snorlax = 143,

            [Description("Articuno")]
            Articuno = 144,

            [Description("Zapdos")]
            Zapdos = 145,

            [Description("Moltres")]
            Moltres = 146,

            [Description("Dratini")]
            Dratini = 147,

            [Description("Dragonair")]
            Dragonair = 148,

            [Description("Dragonite")]
            Dragonite = 149,

            [Description("Mewtwo")]
            Mewtwo = 150,

            [Description("Mew")]
            Mew = 151
        }

        public enum Moves : ushort
        {
            [Description("No Move")]
            NoMove = 0,

            [Description("Pound")]
            Pound = 1,

            [Description("Karate Chop")]
            KarateChop = 2,

            [Description("Double Slap")]
            DoubleSlap = 3,

            [Description("Comet Punch")]
            CometPunch = 4,

            [Description("Mega Punch")]
            MegaPunch = 5,

            [Description("Pay Day")]
            PayDay = 6,

            [Description("Fire Punch")]
            FirePunch = 7,

            [Description("Ice Punch")]
            IcePunch = 8,

            [Description("Thunder Punch")]
            ThunderPunch = 9,

            [Description("Scratch")]
            Scratch = 10,

            [Description("Vice Grip")]
            ViceGrip = 11,

            [Description("Guillotine")]
            Guillotine = 12,

            [Description("Razor Wind")]
            RazorWind = 13,

            [Description("Swords Dance")]
            SwordsDance = 14,

            [Description("Cut")]
            Cut = 15,

            [Description("Gust")]
            Gust = 16,

            [Description("Wing Attack")]
            WingAttack = 17,

            [Description("Whirlwind")]
            Whirlwind = 18,

            [Description("Fly")]
            Fly = 19,

            [Description("Bind")]
            Bind = 20,

            [Description("Slam")]
            Slam = 21,

            [Description("Vine Whip")]
            VineWhip = 22,

            [Description("Stomp")]
            Stomp = 23,

            [Description("Double Kick")]
            DoubleKick = 24,

            [Description("Mega Kick")]
            MegaKick = 25,

            [Description("Jump Kick")]
            JumpKick = 26,

            [Description("Rolling Kick")]
            RollingKick = 27,

            [Description("Sand Attack")]
            SandAttack = 28,

            [Description("Headbutt")]
            Headbutt = 29,

            [Description("Horn Attack")]
            HornAttack = 30,

            [Description("Fury Attack")]
            FuryAttack = 31,

            [Description("Horn Drill")]
            HornDrill = 32,

            [Description("Tackle")]
            Tackle = 33,

            [Description("Body Slam")]
            BodySlam = 34,

            [Description("Wrap")]
            Wrap = 35,

            [Description("Take Down")]
            TakeDown = 36,

            [Description("Thrash")]
            Thrash = 37,

            [Description("Double-Edge")]
            DoubleEdge = 38,

            [Description("Tail Whip")]
            TailWhip = 39,

            [Description("Poison Sting")]
            PoisonSting = 40,

            [Description("Twineedle")]
            Twineedle = 41,

            [Description("Pin Missile")]
            PinMissile = 42,

            [Description("Leer")]
            Leer = 43,

            [Description("Bite")]
            Bite = 44,

            [Description("Growl")]
            Growl = 45,

            [Description("Roar")]
            Roar = 46,

            [Description("Sing")]
            Sing = 47,

            [Description("Supersonic")]
            Supersonic = 48,

            [Description("Sonic Boom")]
            SonicBoom = 49,

            [Description("Disable")]
            Disable = 50,

            [Description("Acid")]
            Acid = 51,

            [Description("Ember")]
            Ember = 52,

            [Description("Flamethrower")]
            Flamethrower = 53,

            [Description("Mist")]
            Mist = 54,

            [Description("Water Gun")]
            WaterGun = 55,

            [Description("Hydro Pump")]
            HydroPump = 56,

            [Description("Surf")]
            Surf = 57,

            [Description("Ice Beam")]
            IceBeam = 58,

            [Description("Blizzard")]
            Blizzard = 59,

            [Description("Psybeam")]
            Psybeam = 60,

            [Description("Bubble Beam")]
            BubbleBeam = 61,

            [Description("Aurora Beam")]
            AuroraBeam = 62,

            [Description("Hyper Beam")]
            HyperBeam = 63,

            [Description("Peck")]
            Peck = 64,

            [Description("Drill Peck")]
            DrillPeck = 65,

            [Description("Submission")]
            Submission = 66,

            [Description("Low Kick")]
            LowKick = 67,

            [Description("Counter")]
            Counter = 68,

            [Description("Seismic Toss")]
            SeismicToss = 69,

            [Description("Strength")]
            Strength = 70,

            [Description("Absorb")]
            Absorb = 71,

            [Description("Mega Drain")]
            MegaDrain = 72,

            [Description("Leech Seed")]
            LeechSeed = 73,

            [Description("Growth")]
            Growth = 74,

            [Description("Razor Leaf")]
            RazorLeaf = 75,

            [Description("Solar Beam")]
            SolarBeam = 76,

            [Description("Poison Powder")]
            PoisonPowder = 77,

            [Description("Stun Spore")]
            StunSpore = 78,

            [Description("Sleep Powder")]
            SleepPowder = 79,

            [Description("Petal Dance")]
            PetalDance = 80,

            [Description("String Shot")]
            StringShot = 81,

            [Description("Dragon Rage")]
            DragonRage = 82,

            [Description("Fire Spin")]
            FireSpin = 83,

            [Description("Thunder Shock")]
            ThunderShock = 84,

            [Description("Thunderbolt")]
            Thunderbolt = 85,

            [Description("Thunder Wave")]
            ThunderWave = 86,

            [Description("Thunder")]
            Thunder = 87,

            [Description("Rock Throw")]
            RockThrow = 88,

            [Description("Earthquake")]
            Earthquake = 89,

            [Description("Fissure")]
            Fissure = 90,

            [Description("Dig")]
            Dig = 91,

            [Description("Toxic")]
            Toxic = 92,

            [Description("Confusion")]
            Confusion = 93,

            [Description("Psychic")]
            Psychic = 94,

            [Description("Hypnosis")]
            Hypnosis = 95,

            [Description("Meditate")]
            Meditate = 96,

            [Description("Agility")]
            Agility = 97,

            [Description("Quick Attack")]
            QuickAttack = 98,

            [Description("Rage")]
            Rage = 99,

            [Description("Teleport")]
            Teleport = 100,

            [Description("Night Shade")]
            NightShade = 101,

            [Description("Mimic")]
            Mimic = 102,

            [Description("Screech")]
            Screech = 103,

            [Description("Double Team")]
            DoubleTeam = 104,

            [Description("Recover")]
            Recover = 105,

            [Description("Harden")]
            Harden = 106,

            [Description("Minimize")]
            Minimize = 107,

            [Description("Smokescreen")]
            Smokescreen = 108,

            [Description("Confuse Ray")]
            ConfuseRay = 109,

            [Description("Withdraw")]
            Withdraw = 110,

            [Description("Defense Curl")]
            DefenseCurl = 111,

            [Description("Barrier")]
            Barrier = 112,

            [Description("Light Screen")]
            LightScreen = 113,

            [Description("Haze")]
            Haze = 114,

            [Description("Reflect")]
            Reflect = 115,

            [Description("Focus Energy")]
            FocusEnergy = 116,

            [Description("Bide")]
            Bide = 117,

            [Description("Metronome")]
            Metronome = 118,

            [Description("Mirror Move")]
            MirrorMove = 119,

            [Description("Self-Destruct")]
            SelfDestruct = 120,

            [Description("Egg Bomb")]
            EggBomb = 121,

            [Description("Lick")]
            Lick = 122,

            [Description("Smog")]
            Smog = 123,

            [Description("Sludge")]
            Sludge = 124,

            [Description("Bone Club")]
            BoneClub = 125,

            [Description("Fire Blast")]
            FireBlast = 126,

            [Description("Waterfall")]
            Waterfall = 127,

            [Description("Clamp")]
            Clamp = 128,

            [Description("Swift")]
            Swift = 129,

            [Description("Skull Bash")]
            SkullBash = 130,

            [Description("Spike Cannon")]
            SpikeCannon = 131,

            [Description("Constrict")]
            Constrict = 132,

            [Description("Amnesia")]
            Amnesia = 133,

            [Description("Kinesis")]
            Kinesis = 134,

            [Description("Soft-Boiled")]
            SoftBoiled = 135,

            [Description("High Jump Kick")]
            HighJumpKick = 136,

            [Description("Glare")]
            Glare = 137,

            [Description("Dream Eater")]
            DreamEater = 138,

            [Description("Poison Gas")]
            PoisonGas = 139,

            [Description("Barrage")]
            Barrage = 140,

            [Description("Leech Life")]
            LeechLife = 141,

            [Description("Lovely Kiss")]
            LovelyKiss = 142,

            [Description("Sky Attack")]
            SkyAttack = 143,

            [Description("Transform")]
            Transform = 144,

            [Description("Bubble")]
            Bubble = 145,

            [Description("Dizzy Punch")]
            DizzyPunch = 146,

            [Description("Spore")]
            Spore = 147,

            [Description("Flash")]
            Flash = 148,

            [Description("Psywave")]
            Psywave = 149,

            [Description("Splash")]
            Splash = 150,

            [Description("Acid Armor")]
            AcidArmor = 151,

            [Description("Crabhammer")]
            Crabhammer = 152,

            [Description("Explosion")]
            Explosion = 153,

            [Description("Fury Swipes")]
            FurySwipes = 154,

            [Description("Bonemerang")]
            Bonemerang = 155,

            [Description("Rest")]
            Rest = 156,

            [Description("Rock Slide")]
            RockSlide = 157,

            [Description("Hyper Fang")]
            HyperFang = 158,

            [Description("Sharpen")]
            Sharpen = 159,

            [Description("Conversion")]
            Conversion = 160,

            [Description("Tri Attack")]
            TriAttack = 161,

            [Description("Super Fang")]
            SuperFang = 162,

            [Description("Slash")]
            Slash = 163,

            [Description("Substitute")]
            Substitute = 164,

            [Description("Struggle")]
            Struggle = 165
        }

        public enum Stats
        {
            Hp,
            Attack,
            Defense,
            Speed,
            Special
        }

        public enum Types
        {
            [Description("Normal")]
            Normal,

            [Description("Fighting")]
            Fighting,

            [Description("Flying")]
            Flying,

            [Description("Poison")]
            Poison,

            [Description("Ground")]
            Ground,

            [Description("Rock")]
            Rock,

            [Description("Bug")]
            Bug,

            [Description("Ghost")]
            Ghost,

            [Description("Fire")]
            Fire,

            [Description("Water")]
            Water,

            [Description("Grass")]
            Grass,

            [Description("Electric")]
            Electric,

            [Description("Psychic")]
            Psychic,

            [Description("Ice")]
            Ice,

            [Description("Dragon")]
            Dragon,
        }

        public enum Languages
        {
            Japanese = 1,
            OfficialRoomaji = 2,
            Korean = 3,
            Chinese = 4,
            French = 5,
            German = 6,
            Spanish = 7,
            Italian = 8,
            English = 9,
            Czech = 10,
        }

        public static IDictionary<ushort, ushort> IndexToSpecies = new Dictionary<ushort, ushort>
        {
            {1,112},
            {2,115},
            {3,32},
            {4,35},
            {5,21},
            {6,100},
            {7,34},
            {8,80},
            {9,2},
            {10,103},
            {11,108},
            {12,102},
            {13,88},
            {14,94},
            {15,29},
            {16,31},
            {17,104},
            {18,111},
            {19,131},
            {20,59},
            {21,151},
            {22,130},
            {23,90},
            {24,72},
            {25,92},
            {26,123},
            {27,120},
            {28,9},
            {29,127},
            {30,114},
            {31,0},
            {32,0},
            {33,58},
            {34,95},
            {35,22},
            {36,16},
            {37,79},
            {38,64},
            {39,75},
            {40,113},
            {41,67},
            {42,122},
            {43,106},
            {44,107},
            {45,24},
            {46,47},
            {47,54},
            {48,96},
            {49,76},
            {50,0},
            {51,126},
            {52,0},
            {53,125},
            {54,82},
            {55,109},
            {56,0},
            {57,56},
            {58,86},
            {59,50},
            {60,128},
            {61,0},
            {62,0},
            {63,0},
            {64,83},
            {65,48},
            {66,149},
            {67,0},
            {68,0},
            {69,0},
            {70,84},
            {71,60},
            {72,124},
            {73,146},
            {74,144},
            {75,145},
            {76,132},
            {77,52},
            {78,98},
            {79,0},
            {80,0},
            {81,0},
            {82,37},
            {83,38},
            {84,25},
            {85,26},
            {86,0},
            {87,0},
            {88,147},
            {89,148},
            {90,140},
            {91,141},
            {92,116},
            {93,117},
            {94,0},
            {95,0},
            {96,27},
            {97,28},
            {98,138},
            {99,139},
            {100,39},
            {101,40},
            {102,133},
            {103,136},
            {104,135},
            {105,134},
            {106,66},
            {107,41},
            {108,23},
            {109,46},
            {110,61},
            {111,62},
            {112,13},
            {113,14},
            {114,15},
            {115,0},
            {116,85},
            {117,57},
            {118,51},
            {119,49},
            {120,87},
            {121,0},
            {122,0},
            {123,10},
            {124,11},
            {125,12},
            {126,68},
            {127,0},
            {128,55},
            {129,97},
            {130,42},
            {131,150},
            {132,143},
            {133,129},
            {134,0},
            {135,0},
            {136,89},
            {137,0},
            {138,99},
            {139,91},
            {140,0},
            {141,101},
            {142,36},
            {143,110},
            {144,53},
            {145,105},
            {146,0},
            {147,93},
            {148,63},
            {149,65},
            {150,17},
            {151,18},
            {152,121},
            {153,1},
            {154,3},
            {155,73},
            {156,0},
            {157,118},
            {158,119},
            {159,0},
            {160,0},
            {161,0},
            {162,0},
            {163,77},
            {164,78},
            {165,19},
            {166,20},
            {167,33},
            {168,30},
            {169,74},
            {170,137},
            {171,142},
            {172,0},
            {173,81},
            {174,0},
            {175,0},
            {176,4},
            {177,7},
            {178,5},
            {179,8},
            {180,6},
            {181,0},
            {182,0},
            {183,0},
            {184,0},
            {185,43},
            {186,44},
            {187,45},
            {188,69},
            {189,70},
            {190,71}
        };
    }
}