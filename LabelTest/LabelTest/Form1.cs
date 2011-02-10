using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //initialize label array with no elements
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            postIt note = new postIt();

            panel1.Controls.Add(note);//add this new panel to the form
            note.Location = new Point(e.X, e.Y); //set the location of the new label
            note.setText(textBox1.Text);

            note.MouseEnter += new EventHandler(label_Enter);
            note.MouseClick += new MouseEventHandler(label_Click);
            note.BackColor = System.Drawing.Color.Red;
        }

        private void label_Enter(Object sender, EventArgs e)
        {
            postIt temp = (postIt)sender;
            textBox1.Text = temp.message;
        }

        private void label_Click(Object sender, MouseEventArgs e)
        {

        }
    }
}
