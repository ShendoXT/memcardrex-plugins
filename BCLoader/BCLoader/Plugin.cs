//MemcardRex plugin interface
//Shendo 2010 - 2012

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Extras;

//Plugin must be in the "rexPluginSystem" namespace in order to be recognised by MemcardRex.
namespace rexPluginSystem
{
    //All plugins should incorporate this interface in order to comunicate with MemcardRex 1.6+.
    public interface rexPluginInterfaceV2
    {
        string getPluginName();
        string getPluginAuthor();
        string getPluginSupportedGames();
        string[] getSupportedProductCodes();
        byte[] editSaveData(byte[] gameSaveData, string saveProductCode);
        void showAboutDialog();
        void showConfigDialog();
    }

    public class rexPlugin : rexPluginInterfaceV2
    {
        private const string pluginName = "BCLoader";
        private const string pluginVersion = "0.2";
        private const string pluginAuthor = "Shendo";
        private const string pluginSupportedGames = "Final Fantasy VII";

        string BCLocation = null;
        string TempLocation = System.IO.Path.GetTempPath();
        string SaveFileName = null;
        xmlSettingsEditor XMLSettings = new xmlSettingsEditor();

        AboutWindow aboutWindow = new AboutWindow();

        //Return Plugin's name (name + plugin version is recommended)
        public string getPluginName()
        {
            return pluginName + " " + pluginVersion;
        }

        //Return Author's name.
        public string getPluginAuthor()
        {
            return pluginAuthor;
        }

        //Return a list of games supported by the plugin
        public string getPluginSupportedGames()
        {
            return pluginSupportedGames;
        }

        //Return a string array of product codes compatible with this plugin.
        //In order to make a product-code-independent-plugin one member should be "*.*".
        public string[] getSupportedProductCodes()
        {
            return new string[] { "SCUS-94163", "SCES-00867", "SCES-00868", "SCES-00869", "SCES-00900", "SLPS-00700", "SLPS-01057" };
        }

        //A data to process. Edited save data should be returned.
        //Array size depends on the number of slots that specific save takes (Save header (128 bytes) + Number of slots * 8192 bytes).
        public byte[] editSaveData(byte[] gameSaveData, string saveProductCode)
        {
            byte[] rawSaveData = new byte[8192];
            byte[] rawSaveName = new byte[21];

            //Load BCLocation from XML file
            if (File.Exists("Plugins/BCLoaderSettings.xml"))
            {
                XMLSettings.openXmlReader("Plugins/BCLoaderSettings.xml");
                BCLocation = XMLSettings.readXmlEntry("BlackChocoboPath");
            }

            //Check if the plugin is configured
            if (BCLocation == null)
            {
                MessageBox.Show("Black Chocobo's path is not set. Open plugin manager to configure it.", pluginName + " " + pluginVersion);
                return null;
            }

            //Copy RAW data from MCS save
            Array.Copy(gameSaveData, 128, rawSaveData, 0, 8192);

            //Copy RAW save name from MCS save
            Array.Copy(gameSaveData, 10, rawSaveName, 0, 20);

            //Set save name
            SaveFileName = Encoding.Default.GetString(rawSaveName);

            //Filter illegal characters from the name
            foreach (char illegalChar in Path.GetInvalidPathChars())
            {
                SaveFileName = SaveFileName.Replace(illegalChar.ToString(), "");
            }

            //Create a file in a TEMP directory
            File.WriteAllBytes(TempLocation + SaveFileName, rawSaveData);

            //Launch Black Chocobo and wait for it to finish (pass file name as argument)
            using (Process proc = Process.Start(BCLocation, TempLocation + SaveFileName))
            {
                proc.WaitForExit();
            }

            //Load edited save to array
            rawSaveData = File.ReadAllBytes(TempLocation + SaveFileName);

            //Inject edited RAW save data
            Array.Copy(rawSaveData, 0, gameSaveData, 128, 8192);

            //Return edited data
            return gameSaveData;
        }

        public void showAboutDialog()
        {
            new AboutWindow().initDialog(pluginName, pluginVersion, "Loader plugin for Black Chocobo", "Author: " + pluginAuthor,
                "Supported product codes:\nSCUS-94163 - NTSC U/C." +
                "\nSCES-00867 - PAL.\nSCES-00868 - PAL.\nSCES-00869 - PAL.\nSCES-00900 - PAL." +
                "\nSLPS-00700 - NTSC J.\nSLPS-01057 - NTSC J.\n\n" +
                pluginName + " is a loader plugin for Final Fantasy VII save\neditor called Black Chocobo.\n" +
                "\nTo select Black Chocobo's exe location\npress the Config button.");
        }


        //Select Black Chocobo's location
        public void showConfigDialog()
        {
            OpenFileDialog OpenFileDLG = new OpenFileDialog();

            OpenFileDLG.Title = "Select executable";
            OpenFileDLG.Filter = "Black Chocobo|Black_Chocobo.exe";

            if (OpenFileDLG.ShowDialog() != DialogResult.OK) return;

            //Set the location to a variable
            BCLocation = OpenFileDLG.FileName;

            //Save the location to an XML file
            XMLSettings.openXmlWriter("Plugins/BCLoaderSettings.xml",pluginName + " " + pluginVersion + " config file");
            XMLSettings.writeXmlEntry("BlackChocoboPath", BCLocation);
            XMLSettings.closeXmlWriter();
        }
    }
}