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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Delete the Schedule tab
            tabManager.Dispose();
        }
        private void ChangeTabColor(DrawItemEventArgs e)
{
Font TabFont;
Brush BackBrush = new SolidBrush(Color.Green); //Set background color
Brush ForeBrush = new SolidBrush(Color.Yellow);//Set foreground color
if (e.Index == this.tabControl1.SelectedIndex)
{
TabFont = new Font(e.Font, FontStyle.Italic | FontStyle.Bold);
}
else
{
TabFont = e.Font;
}
string TabName = this.tabControl1.TabPages[e.Index].Text;
StringFormat sf = new StringFormat();
sf.Alignment = StringAlignment.Center;
e.Graphics.FillRectangle(BackBrush, e.Bounds);
Rectangle r = e.Bounds;
r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);
//Dispose objects
sf.Dispose();
if (e.Index == this.tabControl1.SelectedIndex)
{
TabFont.Dispose();
BackBrush.Dispose();
}
else
{
BackBrush.Dispose();
ForeBrush.Dispose();
}
}

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ChangeTabColor(e);
        }
    }
}
