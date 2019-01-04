using System;
using System.IO;
using System.Runtime.InteropServices;

namespace PKMDS_RBY
{
    // https://bulbapedia.bulbagarden.net/wiki/Save_data_structure_in_Generation_I
    [StructLayout(LayoutKind.Explicit, Size = 0x100000, Pack = 1, CharSet = CharSet.Unicode)]
    [Serializable]
    public class RedBlueSaveFile : ISaveFile
    {
        #region Constants

        private const int FileLength = 0x8000;
        private const int ChecksumDataStart = 0x2598;
        private const int ChecksumDataEnd = 0x3522;
        private const int PlayerNameStart = 0x2598;
        private const int PlayerNameLength = 0xB;
        private const int ChecksumLocation = 0x3523;

        #endregion

        #region Constructors

        public RedBlueSaveFile(Stream fileStream) => ReadFileStream(fileStream);

        public RedBlueSaveFile(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            ReadFileStream(fileStream);
        }

        public RedBlueSaveFile(byte[] fileData) => ReadFileBytes(fileData);

        #endregion

        #region Data Structure

        [FieldOffset(0x00)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = FileLength)]
        internal byte[] data;

        #endregion

        #region Private Properties

        private byte[] PlayerNameData
        {
            get
            {
                byte[] nameData = new byte[PlayerNameLength];
                Array.Copy(data, PlayerNameStart, nameData, 0, PlayerNameLength);
                return nameData;
            }
            set => Array.Copy(value, 0, data, PlayerNameStart, value.Length >= PlayerNameLength ? PlayerNameLength : value.Length);
        }

        #endregion

        #region Public Properties

        public string PlayerName
        {
            get => CustomEncoding.GetString(PlayerNameData);
            set
            {
                PlayerNameData = CustomEncoding.GetBytes(value);
                if (value.Length < PlayerNameLength && value.Length > 0)
                {
                    data[PlayerNameStart + value.Length] = CustomEncoding.TerminationCharacter;
                }
            }
        }

        public byte Checksum
        {
            get => data[ChecksumLocation];
            set => data[ChecksumLocation] = value;
        }

        #endregion

        #region Private Methods

        private void ReadFileStream(Stream fileStream)
        {
            data = new byte[FileLength];
            fileStream.Read(data, 0, FileLength);
        }

        private void ReadFileBytes(byte[] fileBytes)
        {
            if (fileBytes.Length != FileLength)
            {
                throw new Exception($@"Incorrect file size! File size should be {FileLength} bytes.");
            }

            Array.Copy(fileBytes, 0, data, 0, FileLength);
        }

        #endregion

        #region Public Methods

        public byte CalculateChecksum()
        {
            byte checksum = 255;

            for (int i = ChecksumDataStart; i <= ChecksumDataEnd; i++)
            {
                checksum -= data[i];
            }

            return checksum;
        }

        public bool ValidateChecksum() => CalculateChecksum() == Checksum;

        public void FixCheckSums()
        {
            Checksum = CalculateChecksum();
        }

        #endregion
    }
}