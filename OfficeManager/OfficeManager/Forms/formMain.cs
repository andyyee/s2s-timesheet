using System;
using System.Drawing;
using System.Windows.Forms;
using OfficeManager.DatabaseClasses;

namespace OfficeManager
{
    public partial class formMain : Form
    {
        Image postItBackground;
        public formMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PostItDBAccess post = new PostItDBAccess();
            
           //rchtxtbxPostItMessage.Text =  "" + post.getPostItByID("nothing");
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
         * This will call the windows form responsible for setting up this data
         * Note that the event will only be added to the post it if the label is "posted"
         * otherwise it will be allowed to expire
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

        /*
         * This method handles the mouseover event for each label added to the form
         * This effectively tracks the addition of each label to the form
         */
        public void label_Enter(Object sender, EventArgs e)
        {

            postIt temp = (postIt)sender;
            lblPostItMessage.Text = temp.message;
            lblPostItMessage.BackColor = temp.BackColor;
            lblPostItMessage.ForeColor = temp.ForeColor;
        }

        /*
         * This will be implemented later with the purpose of allowing editing of labels
         * The database will be used to make sure that the user has permission to do this
         */
        public void label_Click(Object sender, MouseEventArgs e)
        {

        }

        private void formMain_ResizeBegin(object sender, EventArgs e)
        {
            postItBackground = pnlPostItContainer.BackgroundImage;
            pnlPostItContainer.BackgroundImage = null;
        }

        private void formMain_ResizeEnd(object sender, EventArgs e)
        {
            pnlPostItContainer.BackgroundImage = postItBackground;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void calendarControl22_Load(object sender, EventArgs e)
        {

        }
    }
}
