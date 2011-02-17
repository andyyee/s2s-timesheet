namespace OfficeManager
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabCommunication = new System.Windows.Forms.TabPage();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.tblLytPostItNote = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAnnouncements = new System.Windows.Forms.Panel();
            this.pnlPostItContainer = new System.Windows.Forms.Panel();
            this.rchtxtbxPostItMessage = new System.Windows.Forms.RichTextBox();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.CalendarSchedule = new OfficeManager.CalendarControl();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabs.SuspendLayout();
            this.tabCommunication.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.tblLytPostItNote.SuspendLayout();
            this.pnlPostItContainer.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabHome);
            this.tabs.Controls.Add(this.tabCommunication);
            this.tabs.Controls.Add(this.tabStatus);
            this.tabs.Controls.Add(this.tabProfile);
            this.tabs.Controls.Add(this.tabSchedule);
            this.tabs.Controls.Add(this.tabManager);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1019, 493);
            this.tabs.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1011, 467);
            this.tabHome.TabIndex = 5;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabCommunication
            // 
            this.tabCommunication.Controls.Add(this.pnlHome);
            this.tabCommunication.Location = new System.Drawing.Point(4, 22);
            this.tabCommunication.Name = "tabCommunication";
            this.tabCommunication.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommunication.Size = new System.Drawing.Size(1011, 467);
            this.tabCommunication.TabIndex = 0;
            this.tabCommunication.Text = "Communication";
            this.tabCommunication.UseVisualStyleBackColor = true;
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.tblLytPostItNote);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(3, 3);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1005, 461);
            this.pnlHome.TabIndex = 0;
            // 
            // tblLytPostItNote
            // 
            this.tblLytPostItNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblLytPostItNote.ColumnCount = 2;
            this.tblLytPostItNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.36364F));
            this.tblLytPostItNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.63636F));
            this.tblLytPostItNote.Controls.Add(this.pnlAnnouncements, 0, 0);
            this.tblLytPostItNote.Controls.Add(this.pnlPostItContainer, 1, 0);
            this.tblLytPostItNote.Location = new System.Drawing.Point(-3, -3);
            this.tblLytPostItNote.Name = "tblLytPostItNote";
            this.tblLytPostItNote.RowCount = 1;
            this.tblLytPostItNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPostItNote.Size = new System.Drawing.Size(1008, 467);
            this.tblLytPostItNote.TabIndex = 0;
            // 
            // pnlAnnouncements
            // 
            this.pnlAnnouncements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAnnouncements.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnnouncements.Location = new System.Drawing.Point(3, 3);
            this.pnlAnnouncements.Name = "pnlAnnouncements";
            this.pnlAnnouncements.Size = new System.Drawing.Size(310, 461);
            this.pnlAnnouncements.TabIndex = 0;
            // 
            // pnlPostItContainer
            // 
            this.pnlPostItContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPostItContainer.BackgroundImage = global::OfficeManager.Properties.Resources.fzm_seamless_corkboard1;
            this.pnlPostItContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPostItContainer.Controls.Add(this.rchtxtbxPostItMessage);
            this.pnlPostItContainer.Location = new System.Drawing.Point(319, 3);
            this.pnlPostItContainer.Name = "pnlPostItContainer";
            this.pnlPostItContainer.Size = new System.Drawing.Size(686, 461);
            this.pnlPostItContainer.TabIndex = 1;
            this.pnlPostItContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPostItContainer_MouseClick);
            // 
            // rchtxtbxPostItMessage
            // 
            this.rchtxtbxPostItMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rchtxtbxPostItMessage.Location = new System.Drawing.Point(3, 417);
            this.rchtxtbxPostItMessage.Name = "rchtxtbxPostItMessage";
            this.rchtxtbxPostItMessage.Size = new System.Drawing.Size(686, 39);
            this.rchtxtbxPostItMessage.TabIndex = 0;
            this.rchtxtbxPostItMessage.Text = "";
            // 
            // tabStatus
            // 
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(1011, 467);
            this.tabStatus.TabIndex = 1;
            this.tabStatus.Text = "Status Overview";
            this.tabStatus.UseVisualStyleBackColor = true;
            this.tabStatus.Click += new System.EventHandler(this.ad);
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabProfile.Controls.Add(this.tabControl1);
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(1011, 467);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "View/Edit (OLD!)";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(997, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.CalendarSchedule);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(1011, 467);
            this.tabSchedule.TabIndex = 3;
            this.tabSchedule.Text = "View Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // CalendarSchedule
            // 
            this.CalendarSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.CalendarSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalendarSchedule.Location = new System.Drawing.Point(3, 3);
            this.CalendarSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.CalendarSchedule.Name = "CalendarSchedule";
            this.CalendarSchedule.Size = new System.Drawing.Size(1005, 461);
            this.CalendarSchedule.TabIndex = 0;
            // 
            // tabManager
            // 
            this.tabManager.Location = new System.Drawing.Point(4, 22);
            this.tabManager.Name = "tabManager";
            this.tabManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabManager.Size = new System.Drawing.Size(1011, 467);
            this.tabManager.TabIndex = 4;
            this.tabManager.Text = "Manager Function";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1011, 467);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 493);
            this.Controls.Add(this.tabs);
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabCommunication.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.tblLytPostItNote.ResumeLayout(false);
            this.pnlPostItContainer.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.TabPage tabCommunication;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.TableLayoutPanel tblLytPostItNote;
        private System.Windows.Forms.Panel pnlAnnouncements;
        private System.Windows.Forms.Panel pnlPostItContainer;
        private System.Windows.Forms.RichTextBox rchtxtbxPostItMessage;
        private CalendarControl CalendarSchedule;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

