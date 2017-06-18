//MGSEdit (codename Liquid), a Metal Gear Solid save editor
//Shendo 2010 - 2012

using System;
using System.Collections.Generic;
using System.Text;
using Liquid;
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
        private const string pluginName = "MGSEdit";
        private const string pluginVersion = "0.1";
        private const string pluginAuthor = "Shendo";
        private const string pluginSupportedGames = "Metal Gear Solid";

        //Return Plugin's name (name + plugin version is recommended).
        public string getPluginName()
        {
            return pluginName + " " + pluginVersion;
        }

        //Return Author's name
        public string getPluginAuthor()
        {
            return pluginAuthor;
        }

        //Return a string of supported games
        public string getPluginSupportedGames()
        {
            return pluginSupportedGames;
        }

        //Return a string array of product codes compatible with this plugin.
        //In order to make a product-code-independent-plugin one member should be "*.*".
        public string[] getSupportedProductCodes()
        {
            //American and European versions are supported
            return new string[] { "SLUS-00594", "SLES-01370" };
        }

        //A data to process. Edited save data should be returned.
        //Array size depends on the number of slots that specific save takes (Save header (128 bytes) + Number of slots * 8192 bytes).
        public byte[] editSaveData(byte[] gameSaveData, string saveProductCode)
        {
            //Default fps
            uint gameFPS = 60;

            //Check if this is a PAL game
            if (saveProductCode == "SLES-01370") gameFPS = 50;

            //Check if this is a game data, photo or something else
            switch(gameSaveData[22])
            {
                default:        //Unsupported
                    MessageBox.Show("The selected save is not a MGS game data.", pluginName + " " + pluginVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;

                case 67:        //Photo
                    MessageBox.Show("Photos cannot be edited by this plugin.", pluginName + " " + pluginVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;

                case 71:        //Game data
                    //Make a new instance of the main window
                    mainWindow mainDialog = new mainWindow();

                    //Initialize main dialog
                    return mainDialog.initDialog(pluginName + " " + pluginVersion, gameSaveData, gameFPS);

                case 86:        //VR training data
                    MessageBox.Show("Training data cannot be edited by this plugin.", pluginName + " " + pluginVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
            }
        }

        //Show dialog with extended information about the plugin
        public void showAboutDialog()
        {
            new AboutWindow().initDialog(pluginName, pluginVersion,pluginSupportedGames,"Author: " + pluginAuthor,
                "Supported product codes:\nSLUS-00594 - NTSC U/C.\nSLES-01370 - PAL.\n\nThanks to:\n" +
                "Damien Guard - public domain C# CRC32 code," +
                "\n[pec] authors - their awesome tool helped a lot." +
                "\n\nAll trademarks and copyrights are the\nproperty of their respective owners.");
        }

        //Show configuration dialog if plugin contains configurable options
        public void showConfigDialog()
        {
            MessageBox.Show("This plugin has no options you can configure.", pluginName + " " + pluginVersion);
        }
    }
}