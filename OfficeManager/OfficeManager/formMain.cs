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

        private void pnlPostItContainer_MouseClick(Object sender, MouseEventArgs e)
        {
            postIt note = new postIt();
            FormPostIt Post = new FormPostIt();
            Post.ShowDialog();

            pnlPostItContainer.Controls.Add(note);//add this new panel to the form
            note.Location = new Point(e.X, e.Y); //set the location of the new label
            note.setText(rchtxtbxPostItMessage.Text);

            note.MouseEnter += new EventHandler(label_Enter);
            note.MouseClick += new MouseEventHandler(label_Click);
            note.BackColor = System.Drawing.Color.Red;
            note.Size = new Size(100, 25);
            note.ForeColor = System.Drawing.Color.Blue;
        }
        private void label_Enter(Object sender, EventArgs e)
        {

            postIt temp = (postIt)sender;
            rchtxtbxPostItMessage.Text = temp.message;
        }

        private void label_Click(Object sender, MouseEventArgs e)
        {

        }
    }
}
