using System;
using System.Drawing;
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
            //tabManager.Dispose();

        }

        //private void ChangeTabColor(DrawItemEventArgs e)
        //{
        //    Font TabFont;
        //    Brush BackBrush = new SolidBrush(Color.Green); //Set background color
        //    Brush ForeBrush = new SolidBrush(Color.Yellow);//Set foreground color
        //    if (e.Index == this.tabControl1.SelectedIndex)
        //    {
        //        TabFont = new Font(e.Font, FontStyle.Italic | FontStyle.Bold);
        //    } 
        //    else
        //    {
        //        TabFont = e.Font;
        //    }

        //    string TabName = this.tabControl1.TabPages[e.Index].Text;
        //    StringFormat sf = new StringFormat();
        //    sf.Alignment = StringAlignment.Center;
        //    e.Graphics.FillRectangle(BackBrush, e.Bounds);
        //    Rectangle r = e.Bounds;
        //    r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
        //    e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);
        //    //Dispose objects
        //    sf.Dispose();
        //    if (e.Index == this.tabControl1.SelectedIndex)
        //    {
        //        TabFont.Dispose();
        //        BackBrush.Dispose();
        //    }
        //    else
        //    {
        //        BackBrush.Dispose();
        //        ForeBrush.Dispose();
        //    }
        //}

        //private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    ChangeTabColor(e);
        //}

        private void tabPage1_Click(object sender, EventArgs e)
        {
          
        }

        private void ad(object sender, EventArgs e)
        {

        }

        /*
         * This method handles the click event for the post it panel
         */
        private void pnlPostItContainer_MouseClick(Object sender, MouseEventArgs e)
        {
            postIt note = new postIt();
            FormPostIt Post = new FormPostIt(new Point(e.X, e.Y), pnlPostItContainer, note);
            Post.ShowDialog();
            if (Post.success)
            {
                note.MouseEnter += new EventHandler(label_Enter);
                note.MouseClick += new MouseEventHandler(label_Click);
            }
        }
        public void label_Enter(Object sender, EventArgs e)
        {

            postIt temp = (postIt)sender;
            rchtxtbxPostItMessage.Text = temp.message;
        }

        public void label_Click(Object sender, MouseEventArgs e)
        {

        }
    }
}
