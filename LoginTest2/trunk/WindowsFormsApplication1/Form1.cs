using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Hashtable fakeDB;
        
        public Form1()
        {
            fakeDB = new Hashtable();

            fakeDB.Add(39290,"Joe Smith");
            fakeDB.Add(28939,"Bob Allen");
            fakeDB.Add(19489, "Sam Sneed");
            fakeDB.Add(29190, "Joe Louis");

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int text = System.Convert.ToInt32(this.maskedTextBox1.Text);
            if (fakeDB.ContainsKey(text))
            {
                MessageBox.Show("Welcome, " + fakeDB[text] + ". We have been expecting you.\n");
            }
            else
            {
                MessageBox.Show("You are not welcome in this system.\n");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
