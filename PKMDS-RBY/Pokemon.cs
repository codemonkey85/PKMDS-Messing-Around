using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using static PKMDS_Enums.Enums;

namespace PKMDS_RBY
{
    [StructLayout(LayoutKind.Explicit, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class Pokemon : IEquatable<Pokemon>, IComparable<Pokemon>
    {
        #region Constants

        private const int SpeciesIndexLocation = 0x08;

        #endregion

        #region Constructors and Methods

        public Pokemon() =>
            data = new byte[33];

        public int SortBySpeciesAscending(string name1, string name2) =>
            string.Compare(name1, name2, StringComparison.Ordinal);

        public override bool Equals(object obj)
        {
            Pokemon objAsPart = obj as Pokemon;
            return objAsPart != null && Equals(objAsPart);
        }

        public int CompareTo(Pokemon comparePokemon)
        {
            if (comparePokemon == null)
            {
                return 1;
            }
            if (comparePokemon.Species == Species.NoSpecies)
            {
                return 0;
            }
            return Species.CompareTo(comparePokemon.Species);
        }

        public override int GetHashCode() =>
            //return string.Format("{0}-{1}-{2}-{3}", Checksum, PID, EncryptionKey, species).GetHashCode();
            0;

        public bool Equals(Pokemon other) =>
            other != null && data.SequenceEqual(other.data);

        public static bool operator ==(Pokemon a, Pokemon b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            if (a is null || b is null)
            {
                return false;
            }
            return a.data.SequenceEqual(b.data);
        }

        public static bool operator !=(Pokemon a, Pokemon b) =>
            !(a == b);

        public bool Equals(Species other) =>
            Species == other;

        public static bool operator ==(Pokemon a, Species b)
        {
            if (a is null)
            {
                return false;
            }
            return a.Species == b;
        }

        public static bool operator !=(Pokemon a, Species b) =>
            !(a == b);

        #endregion

        #region Data Structure

        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
        internal byte[] data;

        #endregion

        #region Private Properties

        private ushort SpeciesIndex
        {
            get =>
                BitConverter.ToUInt16(data, SpeciesIndexLocation);
            set =>
                Array.Copy(BitConverter.GetBytes(value), 0, data, SpeciesIndexLocation, 2);
        }

        #endregion

        #region Public Properties

        [DisplayName("Species")]
        public Species Species
        {
            get =>
                Enum.IsDefined(typeof(Species), IndexToSpecies[SpeciesIndex])
                    ? (Species)IndexToSpecies[SpeciesIndex]
                    : Species.NoSpecies;
            set =>
                SpeciesIndex = IndexToSpecies.First(v => v.Value == (ushort)value).Key;
        }

        #endregion

        #region Private Methods

        #endregion

        #region Private Methods

        #endregion
    }
}