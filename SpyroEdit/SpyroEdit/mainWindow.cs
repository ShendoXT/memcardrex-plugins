using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpyroEdit
{
    public partial class mainWindow : Form
    {
        //Flag for the return value
        private bool confirmedFlag = false;
        
        //A flag for the first run
        private bool firstRun = true;

        //Currently edited slot
        private int currentSaveSlot = 0;

        //Currently edited level
        private int currentLevel = 0;

        //A data to edit
        private byte[] saveData = null;

        //Egg information for first 16 levels
        private byte[] eggInfo = { 0, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 2, 1, 2, 2 };

        public mainWindow()
        {
            InitializeComponent();
        }

        //Set up dialog and fetch data
        public byte[] initDialog(string windowTitle, byte[] gameSaveData)
        {
            this.Text = windowTitle;
            saveData = gameSaveData;
            loadData(currentSaveSlot, currentLevel);
            loadLocation(currentSaveSlot);

            //Init default values
            firstRun = true;
            SlotCombo.SelectedIndex = 0;
            levelListbox.SelectedIndex = currentLevel;

            this.ShowDialog();

            //Check what kind of data should be returned to host application (MemcardRex)
            if (confirmedFlag == true) return saveData; else return null;
        }

        //Update slot (save old data, load new data)
        private void updateSlot(int slotValue)
        {
            //Save old data
            if (firstRun == false) updateData(currentSaveSlot, currentLevel);

            //Update current slot
            currentSaveSlot = slotValue;

            //Load new data
            loadData(currentSaveSlot, currentLevel);

            //Load player location
            loadLocation(currentSaveSlot);

            //This is no longer first run
            firstRun = false;
        }

        //Load data from the save
        private void loadData(int slotNumber, int levelNumber)
        {
            byte tempEggInfo = 0;

            //Load gems, dragons, lives and eggs
            livesNumeric.Value = saveData[0x28B + (slotNumber * 0x600)];
            dragonsNumeric.Value = saveData[0x308 + (slotNumber * 0x600) + levelNumber];
            gemsNumeric.Value = saveData[0x32C + (slotNumber * 0x600) + (levelNumber * 2)] | (saveData[0x32C + (slotNumber * 0x600) + (levelNumber * 2) + 1]<<8);

            //Disable and clear egg checkbox
            eggsCheckBox.Checked = false;
            eggsCheckBox.Enabled = false;

            //Clear unlocked checkbox
            unlockedCheckBox.Checked = false;

            //Check if selected level is unlocked
            if (saveData[0x2C0 + currentLevel + (slotNumber * 0x600)] == 1)
                unlockedCheckBox.Checked = true;

            if (currentLevel < 16)
            {
                tempEggInfo = saveData[0x374 + currentLevel + (slotNumber * 0x600)];

                //Enable checkbox for levels with eggs
                if (eggInfo[currentLevel] > 0)
                {
                    eggsCheckBox.Enabled = true;

                    //Check checkbox if eggs are collected
                    if (tempEggInfo == eggInfo[currentLevel])
                    {
                        eggsCheckBox.Checked = true;
                    }
                }
            }
        }

        //Place data in the save
        private void updateData(int slotNumber, int levelNumber)
        {
            //Store lives and dragons (8 bit)
            saveData[0x28B + (slotNumber * 0x600)] = (byte)livesNumeric.Value;
            saveData[0x308 + (slotNumber * 0x600) + levelNumber] = (byte)dragonsNumeric.Value;
            
            //Store gems in little-endian byte order (16 bit)
            saveData[0x32C + (slotNumber * 0x600) + (levelNumber * 2)] = (byte)((uint)gemsNumeric.Value & 0xFF);
            saveData[0x32C + (slotNumber * 0x600) + (levelNumber * 2) + 1] = (byte)(((uint)gemsNumeric.Value & 0xFF00)>>8);

            calcChecksum(slotNumber);
        }

        //Display player location
        private void loadLocation(int slotNumber)
        {
            int stageIndex = 0;

            //In case of a failure
            locationLabelName.Text = "Unknown";

            //Load location name
            if (saveData[0x280 + (slotNumber * 0x600)] >= 10)
            {
                stageIndex = ((saveData[0x280 + (slotNumber * 0x600)] - 10) / 10) * 6;      //World index
                stageIndex += ((saveData[0x280 + (slotNumber * 0x600)] - 10) % 10);     //Stage index

                if (stageIndex < levelListbox.Items.Count)
                {
                    locationLabelName.Text = levelListbox.Items[stageIndex].ToString();
                }
            }
        }

        //Apply a new location
        private void setLocation(int slotNumber)
        {
            byte outputValue = 10;      //Default location (Artisans Home)

            outputValue = (byte)(((levelListbox.SelectedIndex / 6)*10)+10);     //World index
            outputValue += (byte)(levelListbox.SelectedIndex % 6);      //Stage index

            //Place data
            saveData[0x280 + (slotNumber * 0x600)] = outputValue;

            //Reload data
            loadLocation(currentSaveSlot);
        }

        //Calculate checksum for the currently selected slot
        private void calcChecksum(int slotNumber)
        {
            int saveChecksum = 0;

            for (int i = 0; i < 1420; i++)
            {
                saveChecksum += saveData[0x280 + (slotNumber * 0x600) + i];
            }

            //Store checksum in little-endian byte order
            saveData[0x80C + (slotNumber * 0x600)] = (byte)(saveChecksum & 0xFF);
            saveData[0x80D + (slotNumber * 0x600)] = (byte)((saveChecksum & 0xFF00) >> 8);
            saveData[0x80E + (slotNumber * 0x600)] = (byte)((saveChecksum & 0xFF0000) >> 16);
            saveData[0x80F + (slotNumber * 0x600)] = (byte)((saveChecksum & 0xFF000000) >> 24);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Update save data
            updateData(currentSaveSlot, currentLevel);

            //Edited data should be return after pressing OK button
            confirmedFlag = true;
            this.Close();
        }

        private void levelListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update current save data
            updateData(currentSaveSlot, currentLevel);

            //Set the new active level
            currentLevel = levelListbox.SelectedIndex;

            //Load new data
            loadData(currentSaveSlot, currentLevel);
        }

        private void setLocationButton_Click(object sender, EventArgs e)
        {
            //Apply selected location
            setLocation(currentSaveSlot);
        }

        private void eggsCheckBox_Click(object sender, EventArgs e)
        {
            if (eggsCheckBox.Checked == true)
            {
                //Update flag
                saveData[0x374 + currentLevel + (currentSaveSlot * 0x600)] = eggInfo[currentLevel];
            }
            else
            {
                //Clear flag
                saveData[0x374 + currentLevel + (currentSaveSlot * 0x600)] = 0;
            }
        }

        private void unlockedCheckBox_Click(object sender, EventArgs e)
        {
            if (unlockedCheckBox.Checked == true)
            {
                //Unlock level
                saveData[0x2C0 + currentLevel + (currentSaveSlot * 0x600)] = 1;
            }
            else
            {
                //Lock level
                saveData[0x2C0 + currentLevel + (currentSaveSlot * 0x600)] = 0;
            }
        }

        private void mainWindow_Paint(object sender, PaintEventArgs e)
        {
            //Draw gray rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 80)), 0, 0, this.Width, 30);
        }

        private void SlotCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set current save slot
            updateSlot(SlotCombo.SelectedIndex);
        }
    }
}
