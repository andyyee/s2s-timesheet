using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OfficeManager
{
    public partial class FormPostIt : Form
    {
        Color backgroundColor; 
        Color textColor;
        public FormPostIt()
        {
            InitializeComponent();
            textColor = new Color();
            backgroundColor = new Color(); 
        }


        private void Message_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
        private void btnPost_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textColor = Color.Black;
            backgroundColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            //create a new box that will allow the user to pick basic and custom colors
            ColorDialog colorDlg = new ColorDialog();

            //allows the user to pick create a custom background color
            colorDlg.AllowFullOpen = true;

            //if the user presses the OK button the color picked will be chosen for the 
            //background color
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                //changes the current color in the textbox to the current one picked
                textboxMessage.BackColor = colorDlg.Color;
                backgroundColor = colorDlg.Color;                
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            //create a new color dialog box object
            ColorDialog colorDlg = new ColorDialog();

            //allows the user to pick a custom color
            colorDlg.AllowFullOpen = true;

            //allows the user to chose any color from the box
            colorDlg.AnyColor = true;


            //colorDlg.SolidColorOnly = false;

            //colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                //the color choosen will be displayed once the user presses the okay button 
                textboxMessage.ForeColor = colorDlg.Color;
                textColor = colorDlg.Color;
            }
        }

        
    }
}
