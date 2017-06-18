//Save editor for Crash Team Racing
//Shendo 2013

using System;
using System.Collections.Generic;
using System.Text;
using CTREdit;
using System.Windows.Forms;

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
        private const string pluginName = "CTREdit";
        private const string pluginVersion = "0.2";
        private const string pluginAuthor = "Shendo";
        private const string pluginSupportedGames = "Crash Team Racing";

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
            //All versions of CTR are supported
            return new string[] { "SCUS-94426", "SCES-02105", "SCPS-10118" };
        }

        //A data to process. Edited save data should be returned.
        //Array size depends on the number of slots that specific save takes (Save header (128 bytes) + Number of slots * 8192 bytes).
        public byte[] editSaveData(byte[] gameSaveData, string saveProductCode)
        {
            bool japaneseVersion = false;
            
            //Check if this is the Japanese version of the game
            if (saveProductCode == "SCPS-10118") japaneseVersion = true;

            //Make a new instance of the main window
            mainWindow mainDialog = new mainWindow();

            //Initialize main dialog
            return mainDialog.initDialog(pluginName + " " + pluginVersion, gameSaveData, japaneseVersion);
        }

        public void showAboutDialog()
        {
            new AboutWindow().initDialog(pluginName, pluginVersion, pluginSupportedGames, "Author: " + pluginAuthor,
                "Supported product codes:\nSCUS-94426 - NTSC U/C.\nSCES-02105 - PAL.\nSCPS-10118 - NTSC J.\n\nThanks to:\n" +
                "pSX Author - his pSX emulator with debugger\nallowed me to crack the save checksum." +
                "\n\nAll trademarks and copyrights are the\nproperty of their respective owners.");
        }

        public void showConfigDialog()
        {
            MessageBox.Show("This plugin has no options you can configure.", pluginName + " " + pluginVersion);
        }
    }
}