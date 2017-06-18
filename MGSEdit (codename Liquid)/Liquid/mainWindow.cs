using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Liquid
{
    public partial class mainWindow : Form
    {
        //A custom data type used for items and weapons
        private struct mgsItemsData
        {
            public uint currentUnits;
            public uint maxUnits;
            public bool available;
        };

        //Game fps, used for time calculation
        uint mgsFPS = 0;

        //Weapon data
        mgsItemsData[] mgsWeapons = new mgsItemsData[10];

        //Item data
        mgsItemsData[] mgsItems = new mgsItemsData[24];

        //Currently seleced weapon
        int selectedWeapon = 0;

        //Currently selected item
        int selectedItem = 0;

        //Weapon unit descriptor
        string[] weaponUnitDescriptor = { "Bullets", "Bullets", "Grenades", "Rockets", "Missiles", "Mines", "Charges", "Grenades", "Grenades", "Bullets" };

        //Item unit status (0 - Available flag only, 1 - Current unit number only, 2 - Current unit number + max unit number)
        int[] itemUnitStatus = {0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,2,0,1,1,0,0,0,0,0};

        //All locations found in the game
        string[] mgsLocations = {"Unknown", "Dock", "Heliport", "Tank Hangar", "Cell", "Medi room", "Armory", "Armory Sth", "Canyon",
            "Nuke Bldg 1", "Nuke Bldg. B1", "Cmnder room", "Nuke Bldg. B2", "Lab", "Cave", "U.Grnd Pssge", "Comm Twr A",
            "Roof/Comm Twr", "Comm Twr B", "Twr Wall A", "Walkway", "Snowfield", "Blast Furnance", "Cargo Elev.", "Warehouse", 
            "Warehouse Nth", "U.Grnd Base 1", "U.Grnd Base 2", "U.Grnd Base 3", "Cmnd room", "Spply Rte.", "Esc Route"};

        //Index of the current location
        int mgsCurrentLocation = 0;

        //Game option flags
        uint mgsOptions = 0;

        //Save data for editing
        private byte[] saveData = null;

        //Flag for the return value
        private bool confirmedFlag = false;

        public mainWindow()
        {
            InitializeComponent();
        }

        //Set up dialog and fetch data
        public byte[] initDialog(string windowTitle, byte[] gameSaveData, uint fpsRate)
        {
            //Set FPS rate
            mgsFPS = fpsRate;

            //Init default values
            this.Text = windowTitle;
            saveData = gameSaveData;

            //Load data to save editor
            decodeData();

            //Set list indexes to zero
            weaponsCombo.SelectedIndex = 0;
            itemsCombo.SelectedIndex = 0;

            //Show this dialog
            this.ShowDialog();

            //Check what kind of data should be returned to host application (MemcardRex)
            if (confirmedFlag == true) return saveData; else return null;
        }

        //Convert save data to values usable by editor
        private void decodeData()
        {
            //Temp data
            uint tempUnits = 0;
            uint tempMaxUnits = 0;
            uint tempGameTime = 0;

            //Decode weapon data
            for (int i = 0; i < 10; i++)
            {
                //Load values from save data
                tempUnits = get16BitFromSaveData((i * 2) + 0x1E2);
                tempMaxUnits = get16BitFromSaveData((i * 2) + 0x1F6);

                //Check if weapon has not been picked up yet
                if (tempUnits == 0xFFFF)
                {
                    //Set current value to zero
                    tempUnits = 0;
                }
                else
                {
                    //Check if weapon is available (signed flag must not be raised)
                    if ((tempUnits >> 15) == 0) mgsWeapons[i].available = true;

                    //Isolate data (remove flag)
                    tempUnits &= 0x7FFF;

                    //Check if current units are within maximum range
                    if (tempUnits > 9999) tempUnits = 9999;
                }

                //Check if max units are within maximum range
                if (tempMaxUnits > 9999) tempMaxUnits = 9999;

                //Store data in mgsItemData
                mgsWeapons[i].currentUnits = tempUnits;
                mgsWeapons[i].maxUnits = tempMaxUnits;
            }

            //Decode item data
            for (int i = 0; i < 24; i++)
            {
                //Load values from save data
                tempUnits = get16BitFromSaveData((i * 2) + 0x020A);

                //Check if item is available (signed flag must not be raised and quantity must be higher then zero)
                if ((tempUnits >> 15) == 0 && tempUnits > 0) mgsItems[i].available = true;

                //Isolate data (remove flag)
                tempUnits &= 0x7FFF;

                //Check if units are within maximum range (reset if higher)
                if (tempUnits > 9999) tempUnits = 0;

                //Store data in mgsItemData
                mgsItems[i].currentUnits = tempUnits;
            }

            //Decode the un-automated part of the item data
            mgsItems[13].maxUnits = get16BitFromSaveData(0x023A);   //Rations
            mgsItems[14].maxUnits = get16BitFromSaveData(0x023C);   //Cold medicines
            mgsItems[15].maxUnits = get16BitFromSaveData(0x023E);   //Diazepams

            //Load current game time in frames and convert to seconds
            tempGameTime = get32BitFromSaveData(0x190) / mgsFPS;

            //Max allowed game time is 99:59:59 hours
            if (tempGameTime > 359999) tempGameTime = 359999;

            //Apply hours
            hoursNumeric.Value = tempGameTime / 3600;
            tempGameTime -= ((tempGameTime / 3600) * 3600);

            //Apply minutes
            minutesNumeric.Value = tempGameTime / 60;
            tempGameTime -= ((tempGameTime / 60) * 60);

            //Apply seconds
            secondsNumeric.Value = tempGameTime;

            //Get current health
            tempUnits = get16BitFromSaveData(0x1D6);
            if (tempUnits > 1400) tempUnits = 1400;
            currentHealthNumeric.Value = tempUnits;

            //Get maximum health
            tempMaxUnits = get16BitFromSaveData(0x1D8);
            if (tempMaxUnits > 1400) tempMaxUnits = 1400;
            maxHealthNumeric.Value = tempMaxUnits;

            //Get the game difficulty settings
            difficultyCombo.SelectedIndex = (int)get16BitFromSaveData(0x01C2);

            //Load game option flags
            mgsOptions = get16BitFromSaveData(0x01C4);

            //Check if radar should be invisible
            if ((mgsOptions & 0x800) > 0) radarCheckbox.Checked = false;
            else radarCheckbox.Checked = true;

            //Load the game location
            if (saveData[0x1C] > 0x40 && saveData[0x1C] < 0x60) mgsCurrentLocation = saveData[0x1C] - 0x40;

            //Display the game location
            locationLabel.Text = "Location: " + mgsLocations[mgsCurrentLocation];

            //Display current disc number
            if (saveData[0x1B] >= 0x48) diskLabel.Text = "Disc 2"; else diskLabel.Text = "Disc 1";

            //Display cleared number
            clearedLabel.Text = "Cleared: " + ((saveData[0x1B] - 0x40) & 0x7).ToString() + " times(s)";
        }

        //Convert editor values to save data
        private void encodeData()
        {
            //Temp data
            uint tempUnits = 0;
            uint tempMaxUnits = 0;
            uint tempGameTime = 0;

            //Encode weapon data
            for (int i = 0; i < 10; i++)
            {
                //Store data to temp values
                tempUnits = mgsWeapons[i].currentUnits;
                tempMaxUnits = mgsWeapons[i].maxUnits;

                //Raise sign flag if weapon is unavailable
                if (mgsWeapons[i].available == false)
                    tempUnits |= 0x8000;

                //Store values to save data
                set16BitToSaveData(tempUnits, (i * 2) + 0x1E2);
                set16BitToSaveData(tempMaxUnits, (i * 2) + 0x1F6);
            }

            //Encode item data
            for (int i = 0; i < 24; i++)
            {
                //Check if item has an available flag only
                if (itemUnitStatus[i] == 0)
                {
                    if (mgsItems[i].available == true) set16BitToSaveData((ushort)0x1, (i * 2) + 0x020A);
                    else set16BitToSaveData(0x0, (i * 2) + 0x020A);
                }
                else
                {
                    //Store values to save data
                    set16BitToSaveData(mgsItems[i].currentUnits, (i * 2) + 0x020A);
                }
            }

            //Encode the un-automated part of the item data
            set16BitToSaveData(mgsItems[13].maxUnits, 0x023A);      //Rations
            set16BitToSaveData(mgsItems[14].maxUnits, 0x023C);      //Cold medicines
            set16BitToSaveData(mgsItems[15].maxUnits, 0x023E);      //Diazepams

            //Set current health
            set16BitToSaveData((uint)currentHealthNumeric.Value, 0x1D6);

            //Set maximum health
            set16BitToSaveData((uint)maxHealthNumeric.Value, 0x1D8);

            //Encode game time
            tempGameTime = (uint)(((hoursNumeric.Value * 3600) + (minutesNumeric.Value * 60) + secondsNumeric.Value) * mgsFPS);

            //Set game time
            set32BitToSaveData(tempGameTime, 0x190);

            //Set the game difficulty settings
            set16BitToSaveData((uint)difficultyCombo.SelectedIndex, 0x01C2);

            //Set the game radar option
            if (radarCheckbox.Checked == false) set16BitToSaveData((mgsOptions | 0x0800), 0x01C4);
            else set16BitToSaveData((mgsOptions & 0xF7FF), 0x01C4);

            //Update game title
            insertEditedTitle();
        }

        private void insertEditedTitle()
        {
            //Set first digit of the hours (0x4F82 = char '0' in Shift-JIS)
            saveData[0x96] = 0x82;
            saveData[0x97] = (byte)(0x4F + (hoursNumeric.Value / 10));

            //Set second digit of the hours
            saveData[0x98] = 0x82;
            saveData[0x99] = (byte)(0x4F + (hoursNumeric.Value % 10));

            //Set first digit of the minutes
            saveData[0x9C] = 0x82;
            saveData[0x9D] = (byte)(0x4F + (minutesNumeric.Value / 10));

            //Set second digit of the minutes
            saveData[0x9E] = 0x82;
            saveData[0x9F] = (byte)(0x4F + (minutesNumeric.Value % 10));

            //Set time in the save header (starts with ASCII char '0')
            saveData[0x17] = (byte)(0x30 + (hoursNumeric.Value / 10));
            saveData[0x18] = (byte)(0x30 + (hoursNumeric.Value % 10));
            saveData[0x19] = (byte)(0x30 + (minutesNumeric.Value / 10));
            saveData[0x1A] = (byte)(0x30 + (minutesNumeric.Value % 10));

            //Increase time var based on the game difficulty settings
            if ((difficultyCombo.SelectedIndex == 2) || (difficultyCombo.SelectedIndex == 3)) saveData[0x19] = (byte)(saveData[0x19] + 0x40);
            if ((difficultyCombo.SelectedIndex == 1) || (difficultyCombo.SelectedIndex == 3)) saveData[0x1A] = (byte)(saveData[0x1A] + 0x40);
            
            //Set the difficulty display
            switch (difficultyCombo.SelectedIndex)
            {
                default:        //Easy
                    saveData[0x8E] = 0x82;
                    saveData[0x8F] = 0x64;      //E
                    saveData[0x90] = 0x82;
                    saveData[0x91] = 0x79;      //Z
                    break;

                case 1:         //Normal
                    saveData[0x8E] = 0x82;
                    saveData[0x8F] = 0x6D;      //N
                    saveData[0x90] = 0x82;
                    saveData[0x91] = 0x6C;      //M
                    break;

                case 2:         //Hard
                    saveData[0x8E] = 0x82;
                    saveData[0x8F] = 0x67;      //H
                    saveData[0x90] = 0x82;
                    saveData[0x91] = 0x63;      //D
                    break;

                case 3:         //Extreme
                    saveData[0x8E] = 0x82;
                    saveData[0x8F] = 0x64;      //E
                    saveData[0x90] = 0x82;
                    saveData[0x91] = 0x77;      //X
                    break;
            }
        }

        //Set 16 bit unsigned value to memory
        private void set16BitToSaveData(uint saveValue, int byteOffset)
        {
            saveData[byteOffset] = (byte) (saveValue & 0xFF);
            saveData[byteOffset + 1] = (byte)(saveValue >> 8);
        }

        //Set 32 bit unsigned value to memory
        private void set32BitToSaveData(uint saveValue, int byteOffset)
        {
            saveData[byteOffset] = (byte)(saveValue & 0xFF);
            saveData[byteOffset + 1] = (byte)(saveValue >> 8);
            saveData[byteOffset + 2] = (byte)(saveValue >> 16);
            saveData[byteOffset + 3] = (byte)(saveValue >> 24);
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

        //Get 32 bit unsigned value from memory
        private uint get32BitFromSaveData(int byteOffset)
        {
            uint tempData = 0;

            //Get data from the memory
            tempData = saveData[byteOffset];
            tempData |= (uint)(saveData[byteOffset + 1] << 8);
            tempData |= (uint)(saveData[byteOffset + 2] << 16);
            tempData |= (uint)(saveData[byteOffset + 3] << 24);

            //Return data
            return tempData;
        }

        //Calculate CRC32 checksum
        private void calculateChecksum()
        {
            byte[] tempData = new byte[2616];
            UInt32 saveChecksum = 0;

            //Copy save data to temp buffer
            for (int i = 0x188; i < 0xBC0; i++)
                tempData[i - 0x188] = saveData[i];

            //Get the checksum
            saveChecksum = Crc32.Compute(tempData);

            //Store checksum in the save data
            set32BitToSaveData(saveChecksum, 0x184);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Store edited data to save data
            encodeData();

            //Calculate and store checksum
            calculateChecksum();

            //Edited data should be returned after pressing OK button
            confirmedFlag = true;

            //Close this form
            this.Close();
        }

        //User selected another weapon
        private void weaponsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update currently selected weapon
            selectedWeapon = weaponsCombo.SelectedIndex;

            //Update units label
            unitsWeaponsLabel.Text = weaponUnitDescriptor[selectedWeapon] + ":";

            //Get current units
            unitsWeaponsNumeric.Value = mgsWeapons[selectedWeapon].currentUnits;

            //Get maximum units
            maximumWeaponsNumeric.Value = mgsWeapons[selectedWeapon].maxUnits;

            //Check if weapon is available
            if (mgsWeapons[selectedWeapon].available == true)
                availableWeaponsCheckbox.Checked = true;
            else
                availableWeaponsCheckbox.Checked = false;
        }

        //User selected another item
        private void itemsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update currently selected item
            selectedItem = itemsCombo.SelectedIndex;

            //Get current units
            unitsItemNumeric.Value = mgsItems[selectedItem].currentUnits;

            //Get maximum units
            maximumItemsNumeric.Value = mgsItems[selectedItem].maxUnits;

            //Check if item is available
            if (mgsItems[selectedItem].available == true)
                availableItemsCheckbox.Checked = true;
            else
                availableItemsCheckbox.Checked = false;

            //Show extended item data
            unitsItemLabel.Visible = true;
            unitsItemNumeric.Visible = true;
            maximumItemsLabel.Visible = true;
            maximumItemsNumeric.Visible = true;

            //Hide checkbox
            availableItemsCheckbox.Visible = false;

            //Show current units for certain items
            switch (selectedItem)
            {
                default:
                    //Hide extended data for regular items
                    unitsItemLabel.Visible = false;
                    unitsItemNumeric.Visible = false;
                    maximumItemsLabel.Visible = false;
                    maximumItemsNumeric.Visible = false;

                    //Checkbox is visible by default
                    availableItemsCheckbox.Visible = true;
                    break;

                case 13:
                    unitsItemLabel.Text = "Rations:";
                    break;

                case 14:
                    unitsItemLabel.Text = "Medicines:";
                    break;

                case 15:
                    unitsItemLabel.Text = "Diazepams:";
                    break;

                case 17:
                    unitsItemLabel.Text = "Level:";
                    maximumItemsLabel.Visible = false;
                    maximumItemsNumeric.Visible = false;
                    break;

                case 18:
                    unitsItemLabel.Text = "Seconds left:";
                    maximumItemsLabel.Visible = false;
                    maximumItemsNumeric.Visible = false;
                    break;
            }
        }

        //Update current weapon units
        private void unitsWeaponsNumeric_ValueChanged(object sender, EventArgs e)
        {
            mgsWeapons[selectedWeapon].currentUnits = (uint)unitsWeaponsNumeric.Value;
        }

        //Update max weapon units
        private void maximumWeaponsNumeric_ValueChanged(object sender, EventArgs e)
        {
            mgsWeapons[selectedWeapon].maxUnits = (uint)maximumWeaponsNumeric.Value;
        }

        //Update weapon available flag
        private void availableWeaponsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (availableWeaponsCheckbox.Checked == true)
                mgsWeapons[selectedWeapon].available = true;
            else
                mgsWeapons[selectedWeapon].available = false;
        }

        //Update current item units
        private void unitsItemNumeric_ValueChanged(object sender, EventArgs e)
        {
            mgsItems[selectedItem].currentUnits = (uint)unitsItemNumeric.Value;
        }

        //Update max item units
        private void maximumItemsNumeric_ValueChanged(object sender, EventArgs e)
        {
            mgsItems[selectedItem].maxUnits = (uint)maximumItemsNumeric.Value;
        }

        //Update item avaliable flag
        private void availableItemsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (availableItemsCheckbox.Checked == true)
                mgsItems[selectedItem].available = true;
            else
                mgsItems[selectedItem].available = false;
        }
    }
}
