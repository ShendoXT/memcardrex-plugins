namespace SpyroEdit
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
            this.livesLabel = new System.Windows.Forms.Label();
            this.livesNumeric = new System.Windows.Forms.NumericUpDown();
            this.dragonsLabel = new System.Windows.Forms.Label();
            this.dragonsNumeric = new System.Windows.Forms.NumericUpDown();
            this.levelListbox = new System.Windows.Forms.ListBox();
            this.gemsNumeric = new System.Windows.Forms.NumericUpDown();
            this.gemsLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.setLocationButton = new System.Windows.Forms.Button();
            this.locationLabelName = new System.Windows.Forms.Label();
            this.eggsCheckBox = new System.Windows.Forms.CheckBox();
            this.unlockedCheckBox = new System.Windows.Forms.CheckBox();
            this.SlotCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.livesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(184, 236);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 99;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(264, 236);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // livesLabel
            // 
            this.livesLabel.Location = new System.Drawing.Point(188, 96);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(68, 13);
            this.livesLabel.TabIndex = 4;
            this.livesLabel.Text = "Lives:";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // livesNumeric
            // 
            this.livesNumeric.Location = new System.Drawing.Point(260, 92);
            this.livesNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.livesNumeric.Name = "livesNumeric";
            this.livesNumeric.Size = new System.Drawing.Size(76, 20);
            this.livesNumeric.TabIndex = 6;
            // 
            // dragonsLabel
            // 
            this.dragonsLabel.Location = new System.Drawing.Point(184, 216);
            this.dragonsLabel.Name = "dragonsLabel";
            this.dragonsLabel.Size = new System.Drawing.Size(68, 13);
            this.dragonsLabel.TabIndex = 6;
            this.dragonsLabel.Text = "Dragons:";
            this.dragonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dragonsNumeric
            // 
            this.dragonsNumeric.Location = new System.Drawing.Point(260, 212);
            this.dragonsNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.dragonsNumeric.Name = "dragonsNumeric";
            this.dragonsNumeric.Size = new System.Drawing.Size(76, 20);
            this.dragonsNumeric.TabIndex = 10;
            // 
            // levelListbox
            // 
            this.levelListbox.FormattingEnabled = true;
            this.levelListbox.Items.AddRange(new object[] {
            "Artisans Home",
            "Stone Hill",
            "Dark Hollow",
            "Town Square",
            "Toasty",
            "Sunny Flight",
            "Peace Keepers Home",
            "Dry Canyon",
            "Cliff Town",
            "Ice Cavern",
            "Doctor Shemp",
            "Night Flight",
            "Magic Crafters Home",
            "Alpine Ridge",
            "High Caves",
            "Wizard Peak",
            "Blowhard",
            "Crystal Flight",
            "Beast Makers Home",
            "Terrace Village",
            "Misty Bog",
            "Tree Tops",
            "Metalhead",
            "Wild Flight",
            "Dream Weavers Home",
            "Dark Passage",
            "Lofty Castle",
            "Haunted Towers",
            "Jaques",
            "Icy Flight",
            "Gnorc Gnexus",
            "Gnorc Cove",
            "Twilight Harbor",
            "Gnasty Gnorc",
            "Gnasty\'s Loot"});
            this.levelListbox.Location = new System.Drawing.Point(4, 32);
            this.levelListbox.Name = "levelListbox";
            this.levelListbox.Size = new System.Drawing.Size(176, 199);
            this.levelListbox.TabIndex = 4;
            this.levelListbox.SelectedIndexChanged += new System.EventHandler(this.levelListbox_SelectedIndexChanged);
            // 
            // gemsNumeric
            // 
            this.gemsNumeric.Location = new System.Drawing.Point(260, 188);
            this.gemsNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.gemsNumeric.Name = "gemsNumeric";
            this.gemsNumeric.Size = new System.Drawing.Size(76, 20);
            this.gemsNumeric.TabIndex = 9;
            // 
            // gemsLabel
            // 
            this.gemsLabel.Location = new System.Drawing.Point(184, 193);
            this.gemsLabel.Name = "gemsLabel";
            this.gemsLabel.Size = new System.Drawing.Size(68, 13);
            this.gemsLabel.TabIndex = 13;
            this.gemsLabel.Text = "Gems:";
            this.gemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(184, 32);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(79, 13);
            this.locationLabel.TabIndex = 15;
            this.locationLabel.Text = "Player location:";
            // 
            // setLocationButton
            // 
            this.setLocationButton.Location = new System.Drawing.Point(184, 64);
            this.setLocationButton.Name = "setLocationButton";
            this.setLocationButton.Size = new System.Drawing.Size(152, 23);
            this.setLocationButton.TabIndex = 5;
            this.setLocationButton.Text = "Apply selected level";
            this.setLocationButton.UseVisualStyleBackColor = true;
            this.setLocationButton.Click += new System.EventHandler(this.setLocationButton_Click);
            // 
            // locationLabelName
            // 
            this.locationLabelName.AutoSize = true;
            this.locationLabelName.Location = new System.Drawing.Point(184, 48);
            this.locationLabelName.Name = "locationLabelName";
            this.locationLabelName.Size = new System.Drawing.Size(53, 13);
            this.locationLabelName.TabIndex = 18;
            this.locationLabelName.Text = "Unknown";
            // 
            // eggsCheckBox
            // 
            this.eggsCheckBox.AutoSize = true;
            this.eggsCheckBox.Location = new System.Drawing.Point(192, 164);
            this.eggsCheckBox.Name = "eggsCheckBox";
            this.eggsCheckBox.Size = new System.Drawing.Size(102, 17);
            this.eggsCheckBox.TabIndex = 8;
            this.eggsCheckBox.Text = "Collected egg(s)";
            this.eggsCheckBox.UseVisualStyleBackColor = false;
            this.eggsCheckBox.Click += new System.EventHandler(this.eggsCheckBox_Click);
            // 
            // unlockedCheckBox
            // 
            this.unlockedCheckBox.AutoSize = true;
            this.unlockedCheckBox.Location = new System.Drawing.Point(192, 140);
            this.unlockedCheckBox.Name = "unlockedCheckBox";
            this.unlockedCheckBox.Size = new System.Drawing.Size(99, 17);
            this.unlockedCheckBox.TabIndex = 7;
            this.unlockedCheckBox.Text = "Level unlocked";
            this.unlockedCheckBox.UseVisualStyleBackColor = false;
            this.unlockedCheckBox.Click += new System.EventHandler(this.unlockedCheckBox_Click);
            // 
            // SlotCombo
            // 
            this.SlotCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SlotCombo.FormattingEnabled = true;
            this.SlotCombo.Items.AddRange(new object[] {
            "Save slot 1",
            "Save slot 2",
            "Save slot 3"});
            this.SlotCombo.Location = new System.Drawing.Point(4, 5);
            this.SlotCombo.Name = "SlotCombo";
            this.SlotCombo.Size = new System.Drawing.Size(176, 21);
            this.SlotCombo.TabIndex = 1;
            this.SlotCombo.SelectedIndexChanged += new System.EventHandler(this.SlotCombo_SelectedIndexChanged);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 261);
            this.Controls.Add(this.SlotCombo);
            this.Controls.Add(this.dragonsLabel);
            this.Controls.Add(this.gemsLabel);
            this.Controls.Add(this.unlockedCheckBox);
            this.Controls.Add(this.eggsCheckBox);
            this.Controls.Add(this.levelListbox);
            this.Controls.Add(this.locationLabelName);
            this.Controls.Add(this.setLocationButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.gemsNumeric);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.livesNumeric);
            this.Controls.Add(this.dragonsNumeric);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mainWindow";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainWindow_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.livesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gemsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.NumericUpDown livesNumeric;
        private System.Windows.Forms.Label dragonsLabel;
        private System.Windows.Forms.NumericUpDown dragonsNumeric;
        private System.Windows.Forms.ListBox levelListbox;
        private System.Windows.Forms.NumericUpDown gemsNumeric;
        private System.Windows.Forms.Label gemsLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button setLocationButton;
        private System.Windows.Forms.Label locationLabelName;
        private System.Windows.Forms.CheckBox eggsCheckBox;
        private System.Windows.Forms.CheckBox unlockedCheckBox;
        private System.Windows.Forms.ComboBox SlotCombo;
    }
}