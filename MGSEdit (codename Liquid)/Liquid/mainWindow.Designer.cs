namespace Liquid
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.maximumItemsLabel = new System.Windows.Forms.Label();
            this.maximumItemsNumeric = new System.Windows.Forms.NumericUpDown();
            this.unitsItemLabel = new System.Windows.Forms.Label();
            this.unitsItemNumeric = new System.Windows.Forms.NumericUpDown();
            this.availableItemsCheckbox = new System.Windows.Forms.CheckBox();
            this.itemsCombo = new System.Windows.Forms.ComboBox();
            this.maximumWeaponsLabel = new System.Windows.Forms.Label();
            this.maximumWeaponsNumeric = new System.Windows.Forms.NumericUpDown();
            this.unitsWeaponsLabel = new System.Windows.Forms.Label();
            this.unitsWeaponsNumeric = new System.Windows.Forms.NumericUpDown();
            this.availableWeaponsCheckbox = new System.Windows.Forms.CheckBox();
            this.weaponsCombo = new System.Windows.Forms.ComboBox();
            this.hoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.secondsNumeric = new System.Windows.Forms.NumericUpDown();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.minutesNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxHealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.currentHealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxHealthLabel = new System.Windows.Forms.Label();
            this.currentHealthLabel = new System.Windows.Forms.Label();
            this.radarCheckbox = new System.Windows.Forms.CheckBox();
            this.difficultyCombo = new System.Windows.Forms.ComboBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.clearedLabel = new System.Windows.Forms.Label();
            this.diskLabel = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.playerTabPage = new System.Windows.Forms.TabPage();
            this.itemTabPage = new System.Windows.Forms.TabPage();
            this.weaponTabPage = new System.Windows.Forms.TabPage();
            this.optionsTabPage = new System.Windows.Forms.TabPage();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.maximumItemsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsItemNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumWeaponsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsWeaponsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHealthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentHealthNumeric)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            this.playerTabPage.SuspendLayout();
            this.itemTabPage.SuspendLayout();
            this.weaponTabPage.SuspendLayout();
            this.optionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(260, 144);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 99;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(340, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // maximumItemsLabel
            // 
            this.maximumItemsLabel.AutoSize = true;
            this.maximumItemsLabel.Location = new System.Drawing.Point(4, 64);
            this.maximumItemsLabel.Name = "maximumItemsLabel";
            this.maximumItemsLabel.Size = new System.Drawing.Size(54, 13);
            this.maximumItemsLabel.TabIndex = 7;
            this.maximumItemsLabel.Text = "Maximum:";
            // 
            // maximumItemsNumeric
            // 
            this.maximumItemsNumeric.Location = new System.Drawing.Point(88, 60);
            this.maximumItemsNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maximumItemsNumeric.Name = "maximumItemsNumeric";
            this.maximumItemsNumeric.Size = new System.Drawing.Size(72, 20);
            this.maximumItemsNumeric.TabIndex = 6;
            this.maximumItemsNumeric.ValueChanged += new System.EventHandler(this.maximumItemsNumeric_ValueChanged);
            // 
            // unitsItemLabel
            // 
            this.unitsItemLabel.AutoSize = true;
            this.unitsItemLabel.Location = new System.Drawing.Point(4, 40);
            this.unitsItemLabel.Name = "unitsItemLabel";
            this.unitsItemLabel.Size = new System.Drawing.Size(55, 13);
            this.unitsItemLabel.TabIndex = 5;
            this.unitsItemLabel.Text = "Item units:";
            // 
            // unitsItemNumeric
            // 
            this.unitsItemNumeric.Location = new System.Drawing.Point(88, 36);
            this.unitsItemNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unitsItemNumeric.Name = "unitsItemNumeric";
            this.unitsItemNumeric.Size = new System.Drawing.Size(72, 20);
            this.unitsItemNumeric.TabIndex = 4;
            this.unitsItemNumeric.ValueChanged += new System.EventHandler(this.unitsItemNumeric_ValueChanged);
            // 
            // availableItemsCheckbox
            // 
            this.availableItemsCheckbox.AutoSize = true;
            this.availableItemsCheckbox.Location = new System.Drawing.Point(88, 36);
            this.availableItemsCheckbox.Name = "availableItemsCheckbox";
            this.availableItemsCheckbox.Size = new System.Drawing.Size(69, 17);
            this.availableItemsCheckbox.TabIndex = 2;
            this.availableItemsCheckbox.Text = "Available";
            this.availableItemsCheckbox.UseVisualStyleBackColor = true;
            this.availableItemsCheckbox.CheckedChanged += new System.EventHandler(this.availableItemsCheckbox_CheckedChanged);
            // 
            // itemsCombo
            // 
            this.itemsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemsCombo.FormattingEnabled = true;
            this.itemsCombo.Items.AddRange(new object[] {
            "Cigarettes",
            "Magnifying scope",
            "Cardboard box A",
            "Cardboard box B",
            "Cardboard box C",
            "Night-vision goggles",
            "Thermal goggles",
            "Gas mask",
            "Body armor",
            "Ketchup",
            "Stealth",
            "Bandana",
            "Camera",
            "Ration",
            "Cold medicine",
            "Diazepam",
            "PAL card key",
            "ID card",
            "Timer bomb",
            "Mine detector",
            "MO disc",
            "Rope",
            "Handkerchief",
            "Suppressor"});
            this.itemsCombo.Location = new System.Drawing.Point(4, 8);
            this.itemsCombo.Name = "itemsCombo";
            this.itemsCombo.Size = new System.Drawing.Size(156, 21);
            this.itemsCombo.TabIndex = 1;
            this.itemsCombo.SelectedIndexChanged += new System.EventHandler(this.itemsCombo_SelectedIndexChanged);
            // 
            // maximumWeaponsLabel
            // 
            this.maximumWeaponsLabel.AutoSize = true;
            this.maximumWeaponsLabel.Location = new System.Drawing.Point(4, 88);
            this.maximumWeaponsLabel.Name = "maximumWeaponsLabel";
            this.maximumWeaponsLabel.Size = new System.Drawing.Size(54, 13);
            this.maximumWeaponsLabel.TabIndex = 6;
            this.maximumWeaponsLabel.Text = "Maximum:";
            // 
            // maximumWeaponsNumeric
            // 
            this.maximumWeaponsNumeric.Location = new System.Drawing.Point(88, 84);
            this.maximumWeaponsNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.maximumWeaponsNumeric.Name = "maximumWeaponsNumeric";
            this.maximumWeaponsNumeric.Size = new System.Drawing.Size(72, 20);
            this.maximumWeaponsNumeric.TabIndex = 5;
            this.maximumWeaponsNumeric.ValueChanged += new System.EventHandler(this.maximumWeaponsNumeric_ValueChanged);
            // 
            // unitsWeaponsLabel
            // 
            this.unitsWeaponsLabel.AutoSize = true;
            this.unitsWeaponsLabel.Location = new System.Drawing.Point(4, 64);
            this.unitsWeaponsLabel.Name = "unitsWeaponsLabel";
            this.unitsWeaponsLabel.Size = new System.Drawing.Size(76, 13);
            this.unitsWeaponsLabel.TabIndex = 4;
            this.unitsWeaponsLabel.Text = "Weapon units:";
            // 
            // unitsWeaponsNumeric
            // 
            this.unitsWeaponsNumeric.Location = new System.Drawing.Point(88, 60);
            this.unitsWeaponsNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.unitsWeaponsNumeric.Name = "unitsWeaponsNumeric";
            this.unitsWeaponsNumeric.Size = new System.Drawing.Size(72, 20);
            this.unitsWeaponsNumeric.TabIndex = 3;
            this.unitsWeaponsNumeric.ValueChanged += new System.EventHandler(this.unitsWeaponsNumeric_ValueChanged);
            // 
            // availableWeaponsCheckbox
            // 
            this.availableWeaponsCheckbox.AutoSize = true;
            this.availableWeaponsCheckbox.Location = new System.Drawing.Point(88, 36);
            this.availableWeaponsCheckbox.Name = "availableWeaponsCheckbox";
            this.availableWeaponsCheckbox.Size = new System.Drawing.Size(69, 17);
            this.availableWeaponsCheckbox.TabIndex = 1;
            this.availableWeaponsCheckbox.Text = "Available";
            this.availableWeaponsCheckbox.UseVisualStyleBackColor = true;
            this.availableWeaponsCheckbox.CheckedChanged += new System.EventHandler(this.availableWeaponsCheckbox_CheckedChanged);
            // 
            // weaponsCombo
            // 
            this.weaponsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponsCombo.FormattingEnabled = true;
            this.weaponsCombo.Items.AddRange(new object[] {
            "Socom",
            "FA-MAS",
            "Grenade",
            "Nikita",
            "Stinger",
            "Claymore",
            "C4",
            "Stun grenade",
            "Chaff grenade",
            "PSG-1"});
            this.weaponsCombo.Location = new System.Drawing.Point(4, 8);
            this.weaponsCombo.Name = "weaponsCombo";
            this.weaponsCombo.Size = new System.Drawing.Size(156, 21);
            this.weaponsCombo.TabIndex = 0;
            this.weaponsCombo.SelectedIndexChanged += new System.EventHandler(this.weaponsCombo_SelectedIndexChanged);
            // 
            // hoursNumeric
            // 
            this.hoursNumeric.Location = new System.Drawing.Point(8, 80);
            this.hoursNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.hoursNumeric.Name = "hoursNumeric";
            this.hoursNumeric.Size = new System.Drawing.Size(52, 20);
            this.hoursNumeric.TabIndex = 12;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(8, 64);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(38, 13);
            this.hoursLabel.TabIndex = 13;
            this.hoursLabel.Text = "Hours:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(120, 64);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(52, 13);
            this.secondsLabel.TabIndex = 17;
            this.secondsLabel.Text = "Seconds:";
            // 
            // secondsNumeric
            // 
            this.secondsNumeric.Location = new System.Drawing.Point(120, 80);
            this.secondsNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsNumeric.Name = "secondsNumeric";
            this.secondsNumeric.Size = new System.Drawing.Size(52, 20);
            this.secondsNumeric.TabIndex = 16;
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(64, 64);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(47, 13);
            this.minutesLabel.TabIndex = 15;
            this.minutesLabel.Text = "Minutes:";
            // 
            // minutesNumeric
            // 
            this.minutesNumeric.Location = new System.Drawing.Point(64, 80);
            this.minutesNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumeric.Name = "minutesNumeric";
            this.minutesNumeric.Size = new System.Drawing.Size(52, 20);
            this.minutesNumeric.TabIndex = 14;
            // 
            // maxHealthNumeric
            // 
            this.maxHealthNumeric.Location = new System.Drawing.Point(88, 22);
            this.maxHealthNumeric.Maximum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.maxHealthNumeric.Name = "maxHealthNumeric";
            this.maxHealthNumeric.Size = new System.Drawing.Size(80, 20);
            this.maxHealthNumeric.TabIndex = 14;
            // 
            // currentHealthNumeric
            // 
            this.currentHealthNumeric.Location = new System.Drawing.Point(4, 22);
            this.currentHealthNumeric.Maximum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.currentHealthNumeric.Name = "currentHealthNumeric";
            this.currentHealthNumeric.Size = new System.Drawing.Size(80, 20);
            this.currentHealthNumeric.TabIndex = 13;
            // 
            // maxHealthLabel
            // 
            this.maxHealthLabel.AutoSize = true;
            this.maxHealthLabel.Location = new System.Drawing.Point(88, 6);
            this.maxHealthLabel.Name = "maxHealthLabel";
            this.maxHealthLabel.Size = new System.Drawing.Size(54, 13);
            this.maxHealthLabel.TabIndex = 1;
            this.maxHealthLabel.Text = "Maximum:";
            // 
            // currentHealthLabel
            // 
            this.currentHealthLabel.AutoSize = true;
            this.currentHealthLabel.Location = new System.Drawing.Point(4, 6);
            this.currentHealthLabel.Name = "currentHealthLabel";
            this.currentHealthLabel.Size = new System.Drawing.Size(41, 13);
            this.currentHealthLabel.TabIndex = 0;
            this.currentHealthLabel.Text = "Health:";
            // 
            // radarCheckbox
            // 
            this.radarCheckbox.AutoSize = true;
            this.radarCheckbox.Location = new System.Drawing.Point(4, 48);
            this.radarCheckbox.Name = "radarCheckbox";
            this.radarCheckbox.Size = new System.Drawing.Size(80, 17);
            this.radarCheckbox.TabIndex = 3;
            this.radarCheckbox.Text = "Show radar";
            this.radarCheckbox.UseVisualStyleBackColor = true;
            // 
            // difficultyCombo
            // 
            this.difficultyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyCombo.FormattingEnabled = true;
            this.difficultyCombo.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Extreme"});
            this.difficultyCombo.Location = new System.Drawing.Point(4, 20);
            this.difficultyCombo.Name = "difficultyCombo";
            this.difficultyCombo.Size = new System.Drawing.Size(156, 21);
            this.difficultyCombo.TabIndex = 2;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(4, 8);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 18;
            this.locationLabel.Text = "Location:";
            // 
            // clearedLabel
            // 
            this.clearedLabel.AutoSize = true;
            this.clearedLabel.Location = new System.Drawing.Point(4, 24);
            this.clearedLabel.Name = "clearedLabel";
            this.clearedLabel.Size = new System.Drawing.Size(56, 13);
            this.clearedLabel.TabIndex = 20;
            this.clearedLabel.Text = "Cleared #:";
            // 
            // diskLabel
            // 
            this.diskLabel.Location = new System.Drawing.Point(200, 8);
            this.diskLabel.Name = "diskLabel";
            this.diskLabel.Size = new System.Drawing.Size(71, 13);
            this.diskLabel.TabIndex = 19;
            this.diskLabel.Text = "Disc #";
            this.diskLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.infoTabPage);
            this.mainTabControl.Controls.Add(this.playerTabPage);
            this.mainTabControl.Controls.Add(this.itemTabPage);
            this.mainTabControl.Controls.Add(this.weaponTabPage);
            this.mainTabControl.Controls.Add(this.optionsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(132, 4);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(284, 136);
            this.mainTabControl.TabIndex = 21;
            // 
            // infoTabPage
            // 
            this.infoTabPage.Controls.Add(this.secondsLabel);
            this.infoTabPage.Controls.Add(this.clearedLabel);
            this.infoTabPage.Controls.Add(this.secondsNumeric);
            this.infoTabPage.Controls.Add(this.locationLabel);
            this.infoTabPage.Controls.Add(this.minutesLabel);
            this.infoTabPage.Controls.Add(this.diskLabel);
            this.infoTabPage.Controls.Add(this.minutesNumeric);
            this.infoTabPage.Controls.Add(this.hoursLabel);
            this.infoTabPage.Controls.Add(this.hoursNumeric);
            this.infoTabPage.Location = new System.Drawing.Point(4, 22);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoTabPage.Size = new System.Drawing.Size(276, 110);
            this.infoTabPage.TabIndex = 0;
            this.infoTabPage.Text = "Save info";
            this.infoTabPage.UseVisualStyleBackColor = true;
            // 
            // playerTabPage
            // 
            this.playerTabPage.Controls.Add(this.maxHealthNumeric);
            this.playerTabPage.Controls.Add(this.currentHealthNumeric);
            this.playerTabPage.Controls.Add(this.currentHealthLabel);
            this.playerTabPage.Controls.Add(this.maxHealthLabel);
            this.playerTabPage.Location = new System.Drawing.Point(4, 22);
            this.playerTabPage.Name = "playerTabPage";
            this.playerTabPage.Size = new System.Drawing.Size(276, 110);
            this.playerTabPage.TabIndex = 4;
            this.playerTabPage.Text = "Snake";
            this.playerTabPage.UseVisualStyleBackColor = true;
            // 
            // itemTabPage
            // 
            this.itemTabPage.Controls.Add(this.maximumItemsLabel);
            this.itemTabPage.Controls.Add(this.itemsCombo);
            this.itemTabPage.Controls.Add(this.maximumItemsNumeric);
            this.itemTabPage.Controls.Add(this.availableItemsCheckbox);
            this.itemTabPage.Controls.Add(this.unitsItemLabel);
            this.itemTabPage.Controls.Add(this.unitsItemNumeric);
            this.itemTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemTabPage.Name = "itemTabPage";
            this.itemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemTabPage.Size = new System.Drawing.Size(276, 110);
            this.itemTabPage.TabIndex = 1;
            this.itemTabPage.Text = "Items";
            this.itemTabPage.UseVisualStyleBackColor = true;
            // 
            // weaponTabPage
            // 
            this.weaponTabPage.Controls.Add(this.maximumWeaponsLabel);
            this.weaponTabPage.Controls.Add(this.weaponsCombo);
            this.weaponTabPage.Controls.Add(this.maximumWeaponsNumeric);
            this.weaponTabPage.Controls.Add(this.availableWeaponsCheckbox);
            this.weaponTabPage.Controls.Add(this.unitsWeaponsLabel);
            this.weaponTabPage.Controls.Add(this.unitsWeaponsNumeric);
            this.weaponTabPage.Location = new System.Drawing.Point(4, 22);
            this.weaponTabPage.Name = "weaponTabPage";
            this.weaponTabPage.Size = new System.Drawing.Size(276, 110);
            this.weaponTabPage.TabIndex = 2;
            this.weaponTabPage.Text = "Weapons";
            this.weaponTabPage.UseVisualStyleBackColor = true;
            // 
            // optionsTabPage
            // 
            this.optionsTabPage.Controls.Add(this.difficultyLabel);
            this.optionsTabPage.Controls.Add(this.radarCheckbox);
            this.optionsTabPage.Controls.Add(this.difficultyCombo);
            this.optionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.optionsTabPage.Name = "optionsTabPage";
            this.optionsTabPage.Size = new System.Drawing.Size(276, 110);
            this.optionsTabPage.TabIndex = 3;
            this.optionsTabPage.Text = "Options";
            this.optionsTabPage.UseVisualStyleBackColor = true;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(4, 4);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(50, 13);
            this.difficultyLabel.TabIndex = 4;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Liquid.Properties.Resources.SolidSnake;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 164);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 171);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.maximumItemsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsItemNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumWeaponsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsWeaponsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHealthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentHealthNumeric)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.infoTabPage.ResumeLayout(false);
            this.infoTabPage.PerformLayout();
            this.playerTabPage.ResumeLayout(false);
            this.playerTabPage.PerformLayout();
            this.itemTabPage.ResumeLayout(false);
            this.itemTabPage.PerformLayout();
            this.weaponTabPage.ResumeLayout(false);
            this.weaponTabPage.PerformLayout();
            this.optionsTabPage.ResumeLayout(false);
            this.optionsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox itemsCombo;
        private System.Windows.Forms.Label maximumWeaponsLabel;
        private System.Windows.Forms.NumericUpDown maximumWeaponsNumeric;
        private System.Windows.Forms.Label unitsWeaponsLabel;
        private System.Windows.Forms.NumericUpDown unitsWeaponsNumeric;
        private System.Windows.Forms.CheckBox availableWeaponsCheckbox;
        private System.Windows.Forms.ComboBox weaponsCombo;
        private System.Windows.Forms.NumericUpDown hoursNumeric;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.NumericUpDown secondsNumeric;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.NumericUpDown minutesNumeric;
        private System.Windows.Forms.NumericUpDown maxHealthNumeric;
        private System.Windows.Forms.NumericUpDown currentHealthNumeric;
        private System.Windows.Forms.Label maxHealthLabel;
        private System.Windows.Forms.Label currentHealthLabel;
        private System.Windows.Forms.CheckBox availableItemsCheckbox;
        private System.Windows.Forms.NumericUpDown unitsItemNumeric;
        private System.Windows.Forms.Label maximumItemsLabel;
        private System.Windows.Forms.NumericUpDown maximumItemsNumeric;
        private System.Windows.Forms.Label unitsItemLabel;
        private System.Windows.Forms.ComboBox difficultyCombo;
        private System.Windows.Forms.CheckBox radarCheckbox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label diskLabel;
        private System.Windows.Forms.Label clearedLabel;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.TabPage itemTabPage;
        private System.Windows.Forms.TabPage weaponTabPage;
        private System.Windows.Forms.TabPage optionsTabPage;
        private System.Windows.Forms.TabPage playerTabPage;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}