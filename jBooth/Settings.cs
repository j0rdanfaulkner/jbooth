using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jBooth
{
    public partial class Settings : Form
    {
        public Settings(Form MainWindow)
        {
            InitializeComponent();
        }

        private void pbxDarkRed_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxDarkRed.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxDarkRed.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxRed_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxRed.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxRed.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxOrangeRed_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxOrangeRed.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxOrangeRed.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxGold_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxGold.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxGold.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxYellow_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxYellow.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxYellow.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxLimeGreen_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxLimeGreen.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxLimeGreen.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxGreen_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxGreen.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxGreen.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxSeaGreen_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxSeaGreen.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxSeaGreen.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxSteelBlue_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxSteelBlue.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxSteelBlue.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxBlue_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxBlue.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxBlue.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxPurple_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxPurple.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxPurple.BackColor;
            SetLabelColoursBlack();
        }

        private void pbxPink_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = pbxPink.BackColor;
            Program.main.pnlCaptureBar.BackColor = pbxPink.BackColor;
            SetLabelColoursBlack();
        }
        /// <summary>
        /// opens the colour picker dialog so that a custom accent colour can be applied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomColour_Click(object sender, EventArgs e)
        {
            colorPicker.AllowFullOpen = true;
            colorPicker.SolidColorOnly = true;
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color selectedColour = colorPicker.Color;
                btnCustomColour.BackColor = selectedColour;
                Program.main.pnlMenuBar.BackColor = selectedColour;
                Program.main.pnlCaptureBar.BackColor = selectedColour;
                if (selectedColour == Color.Black)
                {
                    SetLabelColoursWhite();
                    btnCustomColour.ForeColor = Color.White;
                }
                else
                {
                    SetLabelColoursBlack();
                    btnCustomColour.ForeColor = Color.Black;
                }
            }
        }
        /// <summary>
        /// sets the appearence of jBooth back to its default parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefaultSettings_Click(object sender, EventArgs e)
        {
            Program.main.pnlMenuBar.BackColor = ColorTranslator.FromHtml("#054686");
            Program.main.pnlCaptureBar.BackColor = ColorTranslator.FromHtml("#054686");
            SetLabelFont("Eurostile LT Std");
        }
        /// <summary>
        /// sets the text colour of labels to black if the accent colour is light
        /// </summary>
        private void SetLabelColoursBlack()
        {
            Program.main.lblAvailableDevices.ForeColor = Color.Black;
            Program.main.lblCaptureFormat.ForeColor = Color.Black;
            Program.main.lblCaptureGallery.ForeColor = Color.Black;
            Program.main.lblTimerEnabled.ForeColor = Color.Black;
        }
        /// <summary>
        /// sets the text colour of labels to white if the accent colour is dark
        /// </summary>
        private void SetLabelColoursWhite()
        {
            Program.main.lblAvailableDevices.ForeColor = Color.White;
            Program.main.lblCaptureFormat.ForeColor = Color.White;
            Program.main.lblCaptureGallery.ForeColor = Color.White;
            Program.main.lblTimerEnabled.ForeColor = Color.White;
        }

        private void cbxSelectedFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxSelectedFont.SelectedIndex)
            {
                default:
                    SetLabelFont(cbxSelectedFont.SelectedItem.ToString());
                    break;
            }
        }
        private void SetLabelFont(string fontname)
        {
            Program.main.lblAvailableDevices.Font = new Font(fontname, Program.main.lblAvailableDevices.Font.Size);
            Program.main.lblCaptureFormat.Font = new Font(fontname, Program.main.lblCaptureFormat.Font.Size);
            Program.main.lblCaptureGallery.Font = new Font(fontname, Program.main.lblCaptureGallery.Font.Size);
            Program.main.lblTimerEnabled.Font = new Font(fontname, Program.main.lblTimerEnabled.Font.Size);
            Program.main.cbxAvailableDevices.Font = new Font(fontname, Program.main.cbxAvailableDevices.Font.Size);
            // default values
            if (fontname == "Eurostile LT Std")
            {
                Program.main.lblAvailableDevices.Font = new Font(fontname, Program.main.lblAvailableDevices.Font.Size, FontStyle.Bold);
                Program.main.lblCaptureFormat.Font = new Font(fontname, Program.main.lblCaptureFormat.Font.Size, FontStyle.Bold);
                Program.main.lblCaptureGallery.Font = new Font(fontname, Program.main.lblCaptureGallery.Font.Size, FontStyle.Bold);
                Program.main.lblTimerEnabled.Font = new Font(fontname, Program.main.lblTimerEnabled.Font.Size, FontStyle.Bold);
                Program.main.cbxAvailableDevices.Font = new Font(fontname, Program.main.cbxAvailableDevices.Font.Size, FontStyle.Bold);
            }
        }
    }
}