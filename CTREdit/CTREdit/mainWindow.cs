using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CTREdit
{
    public partial class mainWindow : Form
    {
        //Save data for editing
        byte[] saveData = null;

        //Editor flags
        bool pressedOK = false;
        bool japaneseVersion = false;

        //Editor data
        private struct saveSlot
        {
            public uint currentCharacter;
            public string playerName;
        }

        //Name of all the stages found in the game
        string[] levelName = {"Crash Cove", "Roo's Tubes", "Sewer Speedway", "Mystery Caves", "Ripper Roo (boss)", "Skull Rock", 
                              "Dingo Canyon", "Tiger Temple", "Papu's Pyramid", "Coco Park", "Papu Papu (boss)", "Rampage Ruins",
                              "Dragon Mines", "Blizzard Bluff", "Polar Pass", "Tiny Arena", "Komodo Joe (boss)", "Rocky Road",
                              "Hot Air Skyway", "Cortex Castle", "N. Gin Labs", "Oxide Station", "Pinstripe (boss)", "Nitro Court",
                              "Slide Coliseum", "Turbo Track", "Nitrous Oxide (boss)", "Dummy", "Dummy", "Dummy"};

        enum levelTypes {regularLevel, bossLevel, battleLevel, timeLevel};

        //Single stage
        private struct singleStage
        {
            public int levelType;
            public int levelWorldIndex;
            public string stageName;
            public bool trophyCollected;
            public bool tokenCollected;
            public bool keyCollected;
            public bool blueRelicCollected;
            public bool goldRelicCollected;
            public bool platinumRelicCollected;
        }

        singleStage[] allStages;

        byte characterUnlockables1 = 0;
        byte characterUnlockables2 = 0;
        byte generalUnlockables = 0;

        //All save slots (4 total)
        saveSlot[] saveSlots = new saveSlot[4];
        int currentSlot = 0;

        public mainWindow()
        {
            InitializeComponent();
        }

        //Set up dialog and fetch data
        public byte[] initDialog(string windowTitle, byte[] gameSaveData, bool isJapanese)
        {
            //Set window title
            this.Text = windowTitle;

            //Pass reference for save data
            saveData = gameSaveData;
            japaneseVersion = isJapanese;

            //Set default values
            currentSlot = 0;

            //Create levels
            createLevels();
            worldListbox.SelectedIndex = 0;

            //Load data
            loadToContainer();
            loadToEditor();

            updateSlotInfo();

            //Show plugin's main dialog
            this.ShowDialog();

            //Save data
            saveFromEditor();
            saveFromContainer();
            calculateChecksum();

            //Check if edited save data should be returned
            if (pressedOK == true) return saveData; else return null;
        }

        //Create all the levels in the game
        private void createLevels()
        {
            //Create array of levels
            allStages = new singleStage[levelName.Length];

            //Cycle through each world
            for (int curWorld = 0; curWorld < 4; curWorld++)
            {
                //Cycle through each stage in the world
                for (int curLevel = 0; curLevel < 6; curLevel++)
                {
                    allStages[curLevel + (6 * curWorld)].levelType = (int)levelTypes.regularLevel;                      //All levels are set to regular by default

                    if (curLevel == 4) allStages[curLevel + (6 * curWorld)].levelType = (int)levelTypes.bossLevel;      //Boss levels
                    if (curLevel == 5) allStages[curLevel + (6 * curWorld)].levelType = (int)levelTypes.battleLevel;    //Battle arena

                    allStages[curLevel + (6 * curWorld)].levelWorldIndex = curWorld;
                    allStages[curLevel + (6 * curWorld)].stageName = levelName[curLevel + (6 * curWorld)];
                    allStages[curLevel + (6 * curWorld)].trophyCollected = false;
                    allStages[curLevel + (6 * curWorld)].tokenCollected = false;
                    allStages[curLevel + (6 * curWorld)].keyCollected = false;
                    allStages[curLevel + (6 * curWorld)].blueRelicCollected = false;
                    allStages[curLevel + (6 * curWorld)].goldRelicCollected = false;
                    allStages[curLevel + (6 * curWorld)].platinumRelicCollected = false;
                }
            }

            //Fix for special levels
            allStages[24].levelType = (int)levelTypes.timeLevel;        //Slide Colliseum
            allStages[25].levelType = (int)levelTypes.timeLevel;        //Turbo track
            allStages[26].levelType = (int)levelTypes.bossLevel;        //Nitrous Oxide
        }

        //Update current slot textbox
        private void updateSlotInfo()
        {
            slotTextBox.Text = "Save slot " + (currentSlot + 1).ToString();
        }

        //Decode save data and load it into container variables
        private void loadToContainer()
        {
            //Load data for each slot
            for (int i = 0; i < 4; i++)
            {
                saveSlots[i].currentCharacter = get16BitFromSaveData(0x1AE + (i * 0x50));

                if (japaneseVersion == false) saveSlots[i].playerName = Encoding.UTF8.GetString(saveData, 0x19C + (i * 0x50), 9);
                else saveSlots[i].playerName = Encoding.Unicode.GetString(saveData, 0x19C + (i * 0x50), 18);
            }

            //Non slot related data
            generalUnlockables = saveData[0x2CC];
            characterUnlockables1 = saveData[0x2C8];
            characterUnlockables2 = saveData[0x2C9];
        }

        //Encode save data to original format
        private void saveFromContainer()
        {
            byte[] tempbyteArray = null;

            //Save data for each slot
            for (int i = 0; i < 4; i++)
            {
                set16BitToSaveData(saveSlots[i].currentCharacter, 0x1AE + (i * 0x50));

                if (japaneseVersion == false)       //America, Europe
                {
                    Array.Clear(saveData, 0x19C + (i * 0x50), 9);
                    tempbyteArray = Encoding.UTF8.GetBytes(saveSlots[i].playerName);
                }
                else
                {
                    Array.Clear(saveData, 0x19C + (i * 0x50), 18);
                    tempbyteArray = Encoding.Unicode.GetBytes(saveSlots[i].playerName);
                }

                //Import player name in the save data
                for (int j = 0; j < tempbyteArray.Length; j++)
                {
                    saveData[0x19C + (i * 0x50) + j] = tempbyteArray[j];
                }
            }

            //Non slot related data
            saveData[0x2CC] = generalUnlockables;
            saveData[0x2C8] = characterUnlockables1;
            saveData[0x2C9] = characterUnlockables2;
        }

        //Load data from container to GUI
        private void loadToEditor()
        {
            //Check if the current slot is active
            if (saveSlots[currentSlot].currentCharacter > 0xF) characterCombo.SelectedIndex = 0;
            else characterCombo.SelectedIndex =(int)(saveSlots[currentSlot].currentCharacter + 1);

            //Player name
            nameTextBox.Text = saveSlots[currentSlot].playerName;

            //Scrapbook mode
            if((generalUnlockables & 0x10) > 0) scrapbookCheckBox.Checked = true; else scrapbookCheckBox.Checked = false;

            //Unlockable characters
            if ((characterUnlockables1 & 0x20) > 0) TropyCheckBox.Checked = true; else TropyCheckBox.Checked = false;
            if ((characterUnlockables1 & 0x40) > 0) PentaCheckBox.Checked = true; else PentaCheckBox.Checked = false;
            if ((characterUnlockables1 & 0x80) > 0) RooCheckBox.Checked = true; else RooCheckBox.Checked = false;

            if ((characterUnlockables2 & 0x1) > 0) PapuCheckBox.Checked = true; else PapuCheckBox.Checked = false;
            if ((characterUnlockables2 & 0x2) > 0) KomodoCheckBox.Checked = true; else KomodoCheckBox.Checked = false;
            if ((characterUnlockables2 & 0x4) > 0) PinstripeCheckBox.Checked = true; else PinstripeCheckBox.Checked = false;
            if ((characterUnlockables2 & 0x8) > 0) FakeCheckBox.Checked = true; else FakeCheckBox.Checked = false;

            //Unlockable arenas
            if ((characterUnlockables1 & 0x4) > 0) parkingCheckbox.Checked = true; else parkingCheckbox.Checked = false;
            if ((characterUnlockables1 & 0x8) > 0) northCheckbox.Checked = true; else northCheckbox.Checked = false;
            if ((characterUnlockables1 & 0x10) > 0) basementCheckbox.Checked = true; else basementCheckbox.Checked = false;
        }

        //Save data from editor to container
        private void saveFromEditor()
        {
            //Check if the current selection is "inactive" or character
            if (characterCombo.SelectedIndex == 0) saveSlots[currentSlot].currentCharacter = 0xFFFF;
            else saveSlots[currentSlot].currentCharacter = (uint)(characterCombo.SelectedIndex - 1);

            //Player name
            saveSlots[currentSlot].playerName = nameTextBox.Text;

            //Scrapbook mode
            if (scrapbookCheckBox.Checked == true) generalUnlockables |= 0x10; else generalUnlockables &= (0x10 ^ 0xFF);

            //Unlockable characters
            if (TropyCheckBox.Checked == true) characterUnlockables1 |= 0x20; else characterUnlockables1 &= (0x20 ^ 0xFF);
            if (PentaCheckBox.Checked == true) characterUnlockables1 |= 0x40; else characterUnlockables1 &= (0x40 ^ 0xFF);
            if (RooCheckBox.Checked == true) characterUnlockables1 |= 0x80; else characterUnlockables1 &= (0x80 ^ 0xFF);

            if (PapuCheckBox.Checked == true) characterUnlockables2 |= 0x1; else characterUnlockables2 &= (0x1 ^ 0xFF);
            if (KomodoCheckBox.Checked == true) characterUnlockables2 |= 0x2; else characterUnlockables2 &= (0x2 ^ 0xFF);
            if (PinstripeCheckBox.Checked == true) characterUnlockables2 |= 0x4; else characterUnlockables2 &= (0x4 ^ 0xFF);
            if (FakeCheckBox.Checked == true) characterUnlockables2 |= 0x8; else characterUnlockables2 &= (0x8 ^ 0xFF);

            //Unlockable arenas
            if (parkingCheckbox.Checked == true) characterUnlockables1 |= 0x4; else characterUnlockables1 &= (0x4 ^ 0xFF);
            if (northCheckbox.Checked == true) characterUnlockables1 |= 0x8; else characterUnlockables1 &= (0x8 ^ 0xFF);
            if (basementCheckbox.Checked == true) characterUnlockables1 |= 0x10; else characterUnlockables1 &= (0x10 ^ 0xFF);
        }

        //Set 16 bit unsigned value to memory
        private void set16BitToSaveData(uint saveValue, int byteOffset)
        {
            saveData[byteOffset] = (byte)(saveValue & 0xFF);
            saveData[byteOffset + 1] = (byte)(saveValue >> 8);
        }

        //Get 16 bit unsigned value from memory
        private uint get16BitFromSaveData(int byteOffset)
        {
            uint tempData = 0;

            //Get data from the memory
            tempData = saveData[byteOffset];
            tempData |= (uint)(saveData[byteOffset + 1] << 8);

            //Return data
            return tempData;
        }

        //Calculate save checksum (in MIPS assembly form, heh :P)
        private void calculateChecksum()
        {
            //Simulated PS1 registers
            uint r2 = 0;
            uint r3 = 0;
            uint r4 = 0;
            uint r5 = 0;
            uint r6 = 0;
            uint r7 = 0;

            //Checksum calculation
            for (uint i = 0; i < 5760; i++)
            {
                //r2 = 0x800992e4 + i;
                r5 = saveData[i + 0x180];
                r3 = 0x7;
                r7 = 0x10000;
                r6 = r7;
                r6 = r6 | 0x1021;

                //Erase old checksum
                saveData[0x17FE] = 0x00;
                saveData[0x17FF] = 0x00;

                while (r3 < 0xFFFF)
                {
                    r4 = r4 << 0x1;
                    r2 = r5 >> (int)r3;
                    r2 = r2 & 0x1;
                    r4 = r4 | r2;
                    r2 = r4 & r7;

                    if (r2 != 0) r4 = r4 ^ r6;

                    r3 = (r3 + 0xFFFF) & 0xFFFF;
                }
            }

            //Set new checksum
            saveData[0x17FE] = (byte)(r4 >> 8);
            saveData[0x17FF] = (byte)(r4 & 0xFF);
        }

        //Change the current save slot by the given value
        private void changeSlot(int deltaValue)
        {
            //Check if the current slot should be changed
            if (deltaValue == -1 & currentSlot == 0) return;
            if (deltaValue == 1 & currentSlot == 3) return;

            //Save current data
            saveFromEditor();

            //Change slot
            currentSlot += deltaValue;
            updateSlotInfo();

            //Load new data
            loadToEditor();
        }

        //Load the appropriate stages for the selected world
        private void worldListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stagesListbox.Items.Clear();

            for (int i = 0; i < 6; i++)
            {
                stagesListbox.Items.Add(levelName[i + (6 * worldListbox.SelectedIndex)]);

                //Check if it's the last world, it has only 3 stages
                if (worldListbox.SelectedIndex > 3 && i > 1) break;
            }

            //Select first stage
            stagesListbox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            pressedOK = true;
            this.Close();
        }

        private void mainWindow_Paint(object sender, PaintEventArgs e)
        {
            //Draw gray rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 80)), 0, 0, this.Width, 30);
        }

        private void characterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set character icon according to the selected character
            characterPictureBox.Image = characterImageList.Images[characterCombo.SelectedIndex];
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            //Go to previous slot
            changeSlot(-1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //Go to next slot
            changeSlot(1);
        }

        //Enable/disable checkboxes for each level
        private void stagesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Disable all checkboxes by default
            trophyCheckbox.Enabled = false;
            tokenCheckbox.Enabled = false;
            keyCheckbox.Enabled = false;
            blueRelicCheckbox.Enabled = false;
            goldRelicCheckbox.Enabled = false;
            platinumRelicCheckbox.Enabled = false;

            //Enable appropriate checkbox
            switch (allStages[(worldListbox.SelectedIndex * 6) + stagesListbox.SelectedIndex].levelType)
            {
                case (int)levelTypes.regularLevel:
                trophyCheckbox.Enabled = true;
                tokenCheckbox.Enabled = true;
                blueRelicCheckbox.Enabled = true;
                goldRelicCheckbox.Enabled = true;
                platinumRelicCheckbox.Enabled = true;
                    break;

                case (int)levelTypes.bossLevel:
                    keyCheckbox.Enabled = true;
                    break;

                case (int)levelTypes.battleLevel:
                    tokenCheckbox.Enabled = true;
                    break;

                case (int)levelTypes.timeLevel:
                blueRelicCheckbox.Enabled = true;
                goldRelicCheckbox.Enabled = true;
                platinumRelicCheckbox.Enabled = true;
                    break;
            }

        }
    }
}
