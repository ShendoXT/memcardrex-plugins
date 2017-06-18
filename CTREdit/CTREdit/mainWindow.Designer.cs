namespace CTREdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.characterLabel = new System.Windows.Forms.Label();
            this.characterCombo = new System.Windows.Forms.ComboBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.unlockableGroupBox = new System.Windows.Forms.GroupBox();
            this.FakeCheckBox = new System.Windows.Forms.CheckBox();
            this.PentaCheckBox = new System.Windows.Forms.CheckBox();
            this.TropyCheckBox = new System.Windows.Forms.CheckBox();
            this.KomodoCheckBox = new System.Windows.Forms.CheckBox();
            this.RooCheckBox = new System.Windows.Forms.CheckBox();
            this.PapuCheckBox = new System.Windows.Forms.CheckBox();
            this.PinstripeCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.scrapbookCheckBox = new System.Windows.Forms.CheckBox();
            this.arenasGroupBox = new System.Windows.Forms.GroupBox();
            this.parkingCheckbox = new System.Windows.Forms.CheckBox();
            this.northCheckbox = new System.Windows.Forms.CheckBox();
            this.basementCheckbox = new System.Windows.Forms.CheckBox();
            this.characterPictureBox = new System.Windows.Forms.PictureBox();
            this.characterImageList = new System.Windows.Forms.ImageList(this.components);
            this.slotTextBox = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.stagesTabPage = new System.Windows.Forms.TabPage();
            this.stageGroupbox = new System.Windows.Forms.GroupBox();
            this.stagesListbox = new System.Windows.Forms.ListBox();
            this.worldGroupbox = new System.Windows.Forms.GroupBox();
            this.worldListbox = new System.Windows.Forms.ListBox();
            this.platinumRelicCheckbox = new System.Windows.Forms.CheckBox();
            this.goldRelicCheckbox = new System.Windows.Forms.CheckBox();
            this.blueRelicCheckbox = new System.Windows.Forms.CheckBox();
            this.keyCheckbox = new System.Windows.Forms.CheckBox();
            this.tokenCheckbox = new System.Windows.Forms.CheckBox();
            this.trophyCheckbox = new System.Windows.Forms.CheckBox();
            this.unlockableGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.arenasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.stagesTabPage.SuspendLayout();
            this.stageGroupbox.SuspendLayout();
            this.worldGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(324, 228);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 99;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(404, 228);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Location = new System.Drawing.Point(56, 6);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(56, 13);
            this.characterLabel.TabIndex = 4;
            this.characterLabel.Text = "Character:";
            // 
            // characterCombo
            // 
            this.characterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterCombo.FormattingEnabled = true;
            this.characterCombo.Items.AddRange(new object[] {
            "Inactive slot",
            "Crash Bandicoot",
            "Dr. Neo Cortex",
            "Tiny Tiger",
            "Coco Bandicoot",
            "N. Gin",
            "Dingodile",
            "Polar",
            "Pura",
            "Pinstripe",
            "Papu Papu",
            "Ripper Roo",
            "Komodo Joe",
            "Dr. N. Tropy",
            "Penta Penguin",
            "Fake Crash"});
            this.characterCombo.Location = new System.Drawing.Point(56, 22);
            this.characterCombo.Name = "characterCombo";
            this.characterCombo.Size = new System.Drawing.Size(120, 21);
            this.characterCombo.TabIndex = 5;
            this.characterCombo.SelectedIndexChanged += new System.EventHandler(this.characterCombo_SelectedIndexChanged);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(4, 60);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(68, 13);
            this.playerLabel.TabIndex = 6;
            this.playerLabel.Text = "Player name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(4, 76);
            this.nameTextBox.MaxLength = 8;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // unlockableGroupBox
            // 
            this.unlockableGroupBox.Controls.Add(this.FakeCheckBox);
            this.unlockableGroupBox.Controls.Add(this.PentaCheckBox);
            this.unlockableGroupBox.Controls.Add(this.TropyCheckBox);
            this.unlockableGroupBox.Controls.Add(this.KomodoCheckBox);
            this.unlockableGroupBox.Controls.Add(this.RooCheckBox);
            this.unlockableGroupBox.Controls.Add(this.PapuCheckBox);
            this.unlockableGroupBox.Controls.Add(this.PinstripeCheckBox);
            this.unlockableGroupBox.Location = new System.Drawing.Point(180, 4);
            this.unlockableGroupBox.Name = "unlockableGroupBox";
            this.unlockableGroupBox.Size = new System.Drawing.Size(136, 156);
            this.unlockableGroupBox.TabIndex = 105;
            this.unlockableGroupBox.TabStop = false;
            this.unlockableGroupBox.Text = "Unlockable characters";
            // 
            // FakeCheckBox
            // 
            this.FakeCheckBox.AutoSize = true;
            this.FakeCheckBox.Location = new System.Drawing.Point(8, 136);
            this.FakeCheckBox.Name = "FakeCheckBox";
            this.FakeCheckBox.Size = new System.Drawing.Size(80, 17);
            this.FakeCheckBox.TabIndex = 15;
            this.FakeCheckBox.Text = "Fake Crash";
            this.FakeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PentaCheckBox
            // 
            this.PentaCheckBox.AutoSize = true;
            this.PentaCheckBox.Location = new System.Drawing.Point(8, 116);
            this.PentaCheckBox.Name = "PentaCheckBox";
            this.PentaCheckBox.Size = new System.Drawing.Size(96, 17);
            this.PentaCheckBox.TabIndex = 14;
            this.PentaCheckBox.Text = "Penta Penguin";
            this.PentaCheckBox.UseVisualStyleBackColor = true;
            // 
            // TropyCheckBox
            // 
            this.TropyCheckBox.AutoSize = true;
            this.TropyCheckBox.Location = new System.Drawing.Point(8, 96);
            this.TropyCheckBox.Name = "TropyCheckBox";
            this.TropyCheckBox.Size = new System.Drawing.Size(84, 17);
            this.TropyCheckBox.TabIndex = 13;
            this.TropyCheckBox.Text = "Dr. N. Tropy";
            this.TropyCheckBox.UseVisualStyleBackColor = true;
            // 
            // KomodoCheckBox
            // 
            this.KomodoCheckBox.AutoSize = true;
            this.KomodoCheckBox.Location = new System.Drawing.Point(8, 76);
            this.KomodoCheckBox.Name = "KomodoCheckBox";
            this.KomodoCheckBox.Size = new System.Drawing.Size(85, 17);
            this.KomodoCheckBox.TabIndex = 12;
            this.KomodoCheckBox.Text = "Komodo Joe";
            this.KomodoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RooCheckBox
            // 
            this.RooCheckBox.AutoSize = true;
            this.RooCheckBox.Location = new System.Drawing.Point(8, 56);
            this.RooCheckBox.Name = "RooCheckBox";
            this.RooCheckBox.Size = new System.Drawing.Size(80, 17);
            this.RooCheckBox.TabIndex = 11;
            this.RooCheckBox.Text = "Ripper Roo";
            this.RooCheckBox.UseVisualStyleBackColor = true;
            // 
            // PapuCheckBox
            // 
            this.PapuCheckBox.AutoSize = true;
            this.PapuCheckBox.Location = new System.Drawing.Point(8, 36);
            this.PapuCheckBox.Name = "PapuCheckBox";
            this.PapuCheckBox.Size = new System.Drawing.Size(79, 17);
            this.PapuCheckBox.TabIndex = 10;
            this.PapuCheckBox.Text = "Papu Papu";
            this.PapuCheckBox.UseVisualStyleBackColor = true;
            // 
            // PinstripeCheckBox
            // 
            this.PinstripeCheckBox.AutoSize = true;
            this.PinstripeCheckBox.Location = new System.Drawing.Point(8, 16);
            this.PinstripeCheckBox.Name = "PinstripeCheckBox";
            this.PinstripeCheckBox.Size = new System.Drawing.Size(66, 17);
            this.PinstripeCheckBox.TabIndex = 9;
            this.PinstripeCheckBox.Text = "Pinstripe";
            this.PinstripeCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.scrapbookCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(4, 100);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(172, 60);
            this.miscGroupBox.TabIndex = 107;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // scrapbookCheckBox
            // 
            this.scrapbookCheckBox.AutoSize = true;
            this.scrapbookCheckBox.Location = new System.Drawing.Point(8, 16);
            this.scrapbookCheckBox.Name = "scrapbookCheckBox";
            this.scrapbookCheckBox.Size = new System.Drawing.Size(107, 17);
            this.scrapbookCheckBox.TabIndex = 8;
            this.scrapbookCheckBox.Text = "Scrapbook mode";
            this.scrapbookCheckBox.UseVisualStyleBackColor = true;
            // 
            // arenasGroupBox
            // 
            this.arenasGroupBox.Controls.Add(this.parkingCheckbox);
            this.arenasGroupBox.Controls.Add(this.northCheckbox);
            this.arenasGroupBox.Controls.Add(this.basementCheckbox);
            this.arenasGroupBox.Location = new System.Drawing.Point(324, 4);
            this.arenasGroupBox.Name = "arenasGroupBox";
            this.arenasGroupBox.Size = new System.Drawing.Size(136, 156);
            this.arenasGroupBox.TabIndex = 106;
            this.arenasGroupBox.TabStop = false;
            this.arenasGroupBox.Text = "Unlockable arenas";
            // 
            // parkingCheckbox
            // 
            this.parkingCheckbox.AutoSize = true;
            this.parkingCheckbox.Location = new System.Drawing.Point(8, 56);
            this.parkingCheckbox.Name = "parkingCheckbox";
            this.parkingCheckbox.Size = new System.Drawing.Size(80, 17);
            this.parkingCheckbox.TabIndex = 18;
            this.parkingCheckbox.Text = "Parking Lot";
            this.parkingCheckbox.UseVisualStyleBackColor = true;
            // 
            // northCheckbox
            // 
            this.northCheckbox.AutoSize = true;
            this.northCheckbox.Location = new System.Drawing.Point(8, 36);
            this.northCheckbox.Name = "northCheckbox";
            this.northCheckbox.Size = new System.Drawing.Size(100, 17);
            this.northCheckbox.TabIndex = 17;
            this.northCheckbox.Text = "The North Bowl";
            this.northCheckbox.UseVisualStyleBackColor = true;
            // 
            // basementCheckbox
            // 
            this.basementCheckbox.AutoSize = true;
            this.basementCheckbox.Location = new System.Drawing.Point(8, 16);
            this.basementCheckbox.Name = "basementCheckbox";
            this.basementCheckbox.Size = new System.Drawing.Size(94, 17);
            this.basementCheckbox.TabIndex = 16;
            this.basementCheckbox.Text = "Lab Basement";
            this.basementCheckbox.UseVisualStyleBackColor = true;
            // 
            // characterPictureBox
            // 
            this.characterPictureBox.Location = new System.Drawing.Point(4, 6);
            this.characterPictureBox.Name = "characterPictureBox";
            this.characterPictureBox.Size = new System.Drawing.Size(48, 48);
            this.characterPictureBox.TabIndex = 104;
            this.characterPictureBox.TabStop = false;
            // 
            // characterImageList
            // 
            this.characterImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("characterImageList.ImageStream")));
            this.characterImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.characterImageList.Images.SetKeyName(0, "NoChar.png");
            this.characterImageList.Images.SetKeyName(1, "Crash.png");
            this.characterImageList.Images.SetKeyName(2, "Cortex.png");
            this.characterImageList.Images.SetKeyName(3, "Tiny.png");
            this.characterImageList.Images.SetKeyName(4, "Coco.png");
            this.characterImageList.Images.SetKeyName(5, "Ngin.png");
            this.characterImageList.Images.SetKeyName(6, "Dingo.png");
            this.characterImageList.Images.SetKeyName(7, "Polar.png");
            this.characterImageList.Images.SetKeyName(8, "Pura.png");
            this.characterImageList.Images.SetKeyName(9, "Pinstripe.png");
            this.characterImageList.Images.SetKeyName(10, "Papu.png");
            this.characterImageList.Images.SetKeyName(11, "Roo.png");
            this.characterImageList.Images.SetKeyName(12, "Komodo.png");
            this.characterImageList.Images.SetKeyName(13, "Tropy.png");
            this.characterImageList.Images.SetKeyName(14, "Penta.png");
            this.characterImageList.Images.SetKeyName(15, "Fake.png");
            // 
            // slotTextBox
            // 
            this.slotTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.slotTextBox.Location = new System.Drawing.Point(4, 5);
            this.slotTextBox.Name = "slotTextBox";
            this.slotTextBox.ReadOnly = true;
            this.slotTextBox.Size = new System.Drawing.Size(100, 20);
            this.slotTextBox.TabIndex = 1;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(108, 4);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(184, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainTabPage);
            this.mainTabControl.Controls.Add(this.stagesTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(4, 32);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(476, 192);
            this.mainTabControl.TabIndex = 108;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.characterPictureBox);
            this.mainTabPage.Controls.Add(this.playerLabel);
            this.mainTabPage.Controls.Add(this.miscGroupBox);
            this.mainTabPage.Controls.Add(this.characterCombo);
            this.mainTabPage.Controls.Add(this.nameTextBox);
            this.mainTabPage.Controls.Add(this.arenasGroupBox);
            this.mainTabPage.Controls.Add(this.characterLabel);
            this.mainTabPage.Controls.Add(this.unlockableGroupBox);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(468, 166);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "Main";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // stagesTabPage
            // 
            this.stagesTabPage.Controls.Add(this.stageGroupbox);
            this.stagesTabPage.Controls.Add(this.worldGroupbox);
            this.stagesTabPage.Controls.Add(this.platinumRelicCheckbox);
            this.stagesTabPage.Controls.Add(this.goldRelicCheckbox);
            this.stagesTabPage.Controls.Add(this.blueRelicCheckbox);
            this.stagesTabPage.Controls.Add(this.keyCheckbox);
            this.stagesTabPage.Controls.Add(this.tokenCheckbox);
            this.stagesTabPage.Controls.Add(this.trophyCheckbox);
            this.stagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.stagesTabPage.Name = "stagesTabPage";
            this.stagesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.stagesTabPage.Size = new System.Drawing.Size(468, 166);
            this.stagesTabPage.TabIndex = 1;
            this.stagesTabPage.Text = "Stages";
            this.stagesTabPage.UseVisualStyleBackColor = true;
            // 
            // stageGroupbox
            // 
            this.stageGroupbox.Controls.Add(this.stagesListbox);
            this.stageGroupbox.Location = new System.Drawing.Point(140, 4);
            this.stageGroupbox.Name = "stageGroupbox";
            this.stageGroupbox.Size = new System.Drawing.Size(200, 156);
            this.stageGroupbox.TabIndex = 18;
            this.stageGroupbox.TabStop = false;
            this.stageGroupbox.Text = "Stage";
            // 
            // stagesListbox
            // 
            this.stagesListbox.FormattingEnabled = true;
            this.stagesListbox.Location = new System.Drawing.Point(8, 16);
            this.stagesListbox.Name = "stagesListbox";
            this.stagesListbox.Size = new System.Drawing.Size(188, 134);
            this.stagesListbox.TabIndex = 17;
            this.stagesListbox.SelectedIndexChanged += new System.EventHandler(this.stagesListbox_SelectedIndexChanged);
            // 
            // worldGroupbox
            // 
            this.worldGroupbox.Controls.Add(this.worldListbox);
            this.worldGroupbox.Location = new System.Drawing.Point(4, 4);
            this.worldGroupbox.Name = "worldGroupbox";
            this.worldGroupbox.Size = new System.Drawing.Size(132, 156);
            this.worldGroupbox.TabIndex = 17;
            this.worldGroupbox.TabStop = false;
            this.worldGroupbox.Text = "World";
            // 
            // worldListbox
            // 
            this.worldListbox.FormattingEnabled = true;
            this.worldListbox.Items.AddRange(new object[] {
            "N. Sanity Beach",
            "The Lost Ruins",
            "Glacier Park",
            "Citadel City",
            "Gem Stone Valley"});
            this.worldListbox.Location = new System.Drawing.Point(8, 16);
            this.worldListbox.Name = "worldListbox";
            this.worldListbox.Size = new System.Drawing.Size(120, 134);
            this.worldListbox.TabIndex = 16;
            this.worldListbox.SelectedIndexChanged += new System.EventHandler(this.worldListbox_SelectedIndexChanged);
            // 
            // platinumRelicCheckbox
            // 
            this.platinumRelicCheckbox.AutoSize = true;
            this.platinumRelicCheckbox.Location = new System.Drawing.Point(356, 136);
            this.platinumRelicCheckbox.Name = "platinumRelicCheckbox";
            this.platinumRelicCheckbox.Size = new System.Drawing.Size(88, 17);
            this.platinumRelicCheckbox.TabIndex = 15;
            this.platinumRelicCheckbox.Text = "Platinum relic";
            this.platinumRelicCheckbox.UseVisualStyleBackColor = true;
            // 
            // goldRelicCheckbox
            // 
            this.goldRelicCheckbox.AutoSize = true;
            this.goldRelicCheckbox.Location = new System.Drawing.Point(356, 112);
            this.goldRelicCheckbox.Name = "goldRelicCheckbox";
            this.goldRelicCheckbox.Size = new System.Drawing.Size(70, 17);
            this.goldRelicCheckbox.TabIndex = 14;
            this.goldRelicCheckbox.Text = "Gold relic";
            this.goldRelicCheckbox.UseVisualStyleBackColor = true;
            // 
            // blueRelicCheckbox
            // 
            this.blueRelicCheckbox.AutoSize = true;
            this.blueRelicCheckbox.Location = new System.Drawing.Point(356, 88);
            this.blueRelicCheckbox.Name = "blueRelicCheckbox";
            this.blueRelicCheckbox.Size = new System.Drawing.Size(69, 17);
            this.blueRelicCheckbox.TabIndex = 13;
            this.blueRelicCheckbox.Text = "Blue relic";
            this.blueRelicCheckbox.UseVisualStyleBackColor = true;
            // 
            // keyCheckbox
            // 
            this.keyCheckbox.AutoSize = true;
            this.keyCheckbox.Location = new System.Drawing.Point(356, 64);
            this.keyCheckbox.Name = "keyCheckbox";
            this.keyCheckbox.Size = new System.Drawing.Size(44, 17);
            this.keyCheckbox.TabIndex = 12;
            this.keyCheckbox.Text = "Key";
            this.keyCheckbox.UseVisualStyleBackColor = true;
            // 
            // tokenCheckbox
            // 
            this.tokenCheckbox.AutoSize = true;
            this.tokenCheckbox.Location = new System.Drawing.Point(356, 40);
            this.tokenCheckbox.Name = "tokenCheckbox";
            this.tokenCheckbox.Size = new System.Drawing.Size(78, 17);
            this.tokenCheckbox.TabIndex = 11;
            this.tokenCheckbox.Text = "CTR token";
            this.tokenCheckbox.UseVisualStyleBackColor = true;
            // 
            // trophyCheckbox
            // 
            this.trophyCheckbox.AutoSize = true;
            this.trophyCheckbox.Location = new System.Drawing.Point(356, 16);
            this.trophyCheckbox.Name = "trophyCheckbox";
            this.trophyCheckbox.Size = new System.Drawing.Size(59, 17);
            this.trophyCheckbox.TabIndex = 10;
            this.trophyCheckbox.Text = "Trophy";
            this.trophyCheckbox.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 255);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.slotTextBox);
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
            this.unlockableGroupBox.ResumeLayout(false);
            this.unlockableGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.arenasGroupBox.ResumeLayout(false);
            this.arenasGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterPictureBox)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainTabPage.PerformLayout();
            this.stagesTabPage.ResumeLayout(false);
            this.stagesTabPage.PerformLayout();
            this.stageGroupbox.ResumeLayout(false);
            this.worldGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.ComboBox characterCombo;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox characterPictureBox;
        private System.Windows.Forms.GroupBox unlockableGroupBox;
        private System.Windows.Forms.CheckBox FakeCheckBox;
        private System.Windows.Forms.CheckBox PentaCheckBox;
        private System.Windows.Forms.CheckBox TropyCheckBox;
        private System.Windows.Forms.CheckBox KomodoCheckBox;
        private System.Windows.Forms.CheckBox RooCheckBox;
        private System.Windows.Forms.CheckBox PapuCheckBox;
        private System.Windows.Forms.CheckBox PinstripeCheckBox;
        private System.Windows.Forms.GroupBox arenasGroupBox;
        private System.Windows.Forms.CheckBox parkingCheckbox;
        private System.Windows.Forms.CheckBox northCheckbox;
        private System.Windows.Forms.CheckBox basementCheckbox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox scrapbookCheckBox;
        private System.Windows.Forms.ImageList characterImageList;
        private System.Windows.Forms.TextBox slotTextBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage stagesTabPage;
        private System.Windows.Forms.ListBox worldListbox;
        private System.Windows.Forms.CheckBox platinumRelicCheckbox;
        private System.Windows.Forms.CheckBox goldRelicCheckbox;
        private System.Windows.Forms.CheckBox blueRelicCheckbox;
        private System.Windows.Forms.CheckBox keyCheckbox;
        private System.Windows.Forms.CheckBox tokenCheckbox;
        private System.Windows.Forms.CheckBox trophyCheckbox;
        private System.Windows.Forms.GroupBox stageGroupbox;
        private System.Windows.Forms.ListBox stagesListbox;
        private System.Windows.Forms.GroupBox worldGroupbox;
    }
}