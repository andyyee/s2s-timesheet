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
        Color textColor = Color.Black;
        private Point location;
        public Panel holder;
        public postIt note;
        public Boolean success = false;
        
        public FormPostIt(Point location, Panel holder, postIt note)
        {
            InitializeComponent();
            textColor = new Color();
            backgroundColor = new Color();
            this.location = location;
            this.holder = holder;
            this.note = note;
        }

        /*
         * This method generates a label with the specified traits
         * A note has a background and text color, subject, and message
         * The user is restricted to 25 characters in the subject, and no message limit
         */
        private void btnPost_Click(object sender, EventArgs e)
        {
            holder.Controls.Add(note);
            note.Location = location;
            note.Text = txtbxSubject.Text;
            note.message = txtbxMessage.Text;
            note.BackColor = backgroundColor;
            note.ForeColor = textColor;
            note.Size = new Size(130, 20);
            success = true;
            this.Dispose();
        }

        //clears the components in the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            textColor = Color.Black;
            backgroundColor = Color.Black;
            txtbxMessage.Text = "";
            txtbxSubject.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtbxSubject_TextChanged(object sender, EventArgs e)
        {
            lblCounter.Text = txtbxSubject.Text.Length.ToString();
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
                txtbxMessage.BackColor = colorDlg.Color;
                txtbxSubject.BackColor = colorDlg.Color;
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

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                //the color chosen will be displayed once the user presses the okay button 
                txtbxMessage.ForeColor = colorDlg.Color;
                txtbxSubject.ForeColor = colorDlg.Color;
                textColor = colorDlg.Color;
            }
        }
    }
}
