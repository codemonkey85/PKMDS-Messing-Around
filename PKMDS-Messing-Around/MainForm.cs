using PKMDS_RBY;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VeekunHelper;

namespace PKMDS_Messing_Around
{
    public partial class MainForm : Form
    {
        public const string RedSaveFileName = @"Pokemon Red.sav";
        public const string BlueSaveFileName = @"Pokemon Blue.sav";
        public const string YellowSaveFileName = @"Pokemon Yellow.sav";

        public const string TestSaveFilesDir = @"Test Save Files";

        public MainForm() => InitializeComponent();

        private void buttonTest_Click(object sender, EventArgs e)
        {
            FileStream redSaveFileStream = new FileStream(Path.Combine(TestSaveFilesDir, RedSaveFileName), FileMode.Open, FileAccess.Read);
            RedBlueSaveFile redSaveFileData = new RedBlueSaveFile(redSaveFileStream);

            FileStream blueSaveFileStream = new FileStream(Path.Combine(TestSaveFilesDir, BlueSaveFileName), FileMode.Open, FileAccess.Read);
            RedBlueSaveFile blueSaveFileData = new RedBlueSaveFile(blueSaveFileStream);

            FileStream yellowSaveFileStream = new FileStream(Path.Combine(TestSaveFilesDir, YellowSaveFileName), FileMode.Open, FileAccess.Read);
            YellowSaveFile yellowSaveFileData = new YellowSaveFile(yellowSaveFileStream);

            //DataRow test = VeekunDatabase.VeekunDataSet.Tables["pokemon_species_names"].Select($"pokemon_species_id = {pokemonSpeciesId} AND local_language_id = {localLangIdEnglish}").First();
            //DataView dataView = new DataView(VeekunDatabase.VeekunDataSet.Tables["pokemon_species_names"], $"pokemon_species_id = {pokemonSpeciesId} AND local_language_id = {localLangIdEnglish}", "", DataViewRowState.CurrentRows);

            //var test = VeekunDatabase.VeekunDataSet.Tables["pokemon_species_names"]
            //    .AsEnumerable()
            //    .FirstOrDefault(row =>
            //        row.Field<long>("pokemon_species_id") == pokemonSpeciesId &&
            //        row.Field<long>("local_language_id") == localLangIdEnglish)
            //    .Field<string>("name");

            VeekunDatabase.TestDapper();

            //redSaveFileData.PlayerName = "Mike";
            //Console.WriteLine(redSaveFileData.PlayerName);

            //Pokemon pkm = new Pokemon
            //{
            //    Species = Enums.Species.Abra
            //};

            //MessageBox.Show($@"This Pokémon's species is '{pkm.Species.GetEnumDescription()}'.", @"Pokémon Species", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //using (SQLiteConnection test = new SQLiteConnection(""))
            //{
            //    test.Open();
            //    using (SQLiteCommand cmd = test.CreateCommand())
            //    {
            //        cmd.CommandText = "";
            //    }
            //    test.Close();
            //}
        }
    }
}