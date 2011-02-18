using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace OfficeManager
{
    public partial class formLogin : Form
    {
        Hashtable fakeDB, fakePass, fakeUser;
        bool validLogin = false;
        int userid = -1;
        String username="";
        String realname="";

        public formLogin()
        {
            fakeDB = new Hashtable();
            fakePass = new Hashtable();
            fakeUser = new Hashtable();

            fakeUser.Add("", 00000);
            fakeUser.Add("smith", 39290);
            fakeUser.Add("allen", 28939);
            fakeUser.Add("sneed", 19489);
            fakeUser.Add("louis", 29190);

            fakeDB.Add(00000, "Bob Lewis");
            fakeDB.Add(39290, "Joe Smith");
            fakeDB.Add(28939, "Bob Allen");
            fakeDB.Add(19489, "Sam Sneed");
            fakeDB.Add(29190, "Joe Louis");

            fakePass.Add(00000, "");
            fakePass.Add(39290, "cookie");
            fakePass.Add(28939, "blueberries");
            fakePass.Add(19489, "secure123");
            fakePass.Add(29190, "abc123");

            InitializeComponent();
        }

        public bool getLoginValid()
        {
            return validLogin;
        }

        public int getLoginId()
        {
            return userid;
        }

        public String getLoginName()
        {
            return username;
        }

        public String getRealName()
        {
            return realname;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = this.textBox2.Text;
            String pass = this.textBox1.Text;
            if (fakeUser.ContainsKey(text) && fakePass.ContainsKey(fakeUser[text]) && fakePass[fakeUser[text]].Equals(pass))
            {
                validLogin = true;
                userid = (int)fakeUser[text];
                realname = (String)fakeDB[fakeUser[text]];
                username = text;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid username and/or password. Please try again.");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
