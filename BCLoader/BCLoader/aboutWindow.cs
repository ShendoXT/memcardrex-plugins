//Generic about window
//Shendo 2009-2012

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Extras
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        public void initDialog(string applicationName, string applicationVersion, string supportedGames, string copyrightInfo, string additionalInfo)
        {
            //Set Window title
            this.Text = "About";

            //Display program name
            appNameLabel.Text = applicationName;

            //Display program version
            appVersionLabel.Text = "Version: " + applicationVersion;

            //Display program compile date
            supportedGamesLabel.Text = supportedGames;

            //Display copyright information
            copyrightLabel.Text = copyrightInfo;

            //Display other info
            infoLabel.Text = additionalInfo;

            //Resize dialog according to the quantity of text
            this.Size = new Size(this.Size.Width, 132 + infoLabel.Height);

            //Display a dialog
            this.ShowDialog();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void AboutWindow_Paint(object sender, PaintEventArgs e)
        {
            //Draw gray rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80,80,80)), 0, 0, this.Width, 52);
        }
    }
}
