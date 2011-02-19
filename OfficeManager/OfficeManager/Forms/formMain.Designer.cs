﻿namespace OfficeManager
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
            this.tblLytPostItNote = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPostItContainer = new System.Windows.Forms.Panel();
            this.lblPostItMessage = new System.Windows.Forms.Label();
            this.pnlAnnouncements = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.calendarSchedule = new OfficeManager.CalendarControl();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabCommunication.SuspendLayout();
            this.tblLytPostItNote.SuspendLayout();
            this.pnlPostItContainer.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabHome);
            this.tabs.Controls.Add(this.tabCommunication);
            this.tabs.Controls.Add(this.tabStatus);
            this.tabs.Controls.Add(this.tabSchedule);
            this.tabs.Controls.Add(this.tabManager);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(994, 522);
            this.tabs.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(986, 496);
            this.tabHome.TabIndex = 5;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabCommunication
            // 
            this.tabCommunication.Controls.Add(this.tblLytPostItNote);
            this.tabCommunication.Controls.Add(this.pnlHome);
            this.tabCommunication.Location = new System.Drawing.Point(4, 22);
            this.tabCommunication.Name = "tabCommunication";
            this.tabCommunication.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommunication.Size = new System.Drawing.Size(986, 496);
            this.tabCommunication.TabIndex = 0;
            this.tabCommunication.Text = "Communication";
            this.tabCommunication.UseVisualStyleBackColor = true;
            // 
            // tblLytPostItNote
            // 
            this.tblLytPostItNote.ColumnCount = 2;
            this.tblLytPostItNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.36364F));
            this.tblLytPostItNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.63636F));
            this.tblLytPostItNote.Controls.Add(this.pnlPostItContainer, 1, 0);
            this.tblLytPostItNote.Controls.Add(this.pnlAnnouncements, 0, 0);
            this.tblLytPostItNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytPostItNote.Location = new System.Drawing.Point(3, 3);
            this.tblLytPostItNote.Name = "tblLytPostItNote";
            this.tblLytPostItNote.RowCount = 1;
            this.tblLytPostItNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytPostItNote.Size = new System.Drawing.Size(186, 68);
            this.tblLytPostItNote.TabIndex = 0;
            // 
            // pnlPostItContainer
            // 
            this.pnlPostItContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPostItContainer.BackgroundImage = global::OfficeManager.Properties.Resources.fzm_seamless_corkboard1;
            this.pnlPostItContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPostItContainer.Controls.Add(this.lblPostItMessage);
            this.pnlPostItContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPostItContainer.Location = new System.Drawing.Point(61, 3);
            this.pnlPostItContainer.Name = "pnlPostItContainer";
            this.pnlPostItContainer.Size = new System.Drawing.Size(122, 62);
            this.pnlPostItContainer.TabIndex = 1;
            this.pnlPostItContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPostItContainer_MouseClick);
            // 
            // lblPostItMessage
            // 
            this.lblPostItMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostItMessage.BackColor = System.Drawing.Color.White;
            this.lblPostItMessage.Location = new System.Drawing.Point(3, 23);
            this.lblPostItMessage.Name = "lblPostItMessage";
            this.lblPostItMessage.Size = new System.Drawing.Size(114, 31);
            this.lblPostItMessage.TabIndex = 0;
            // 
            // pnlAnnouncements
            // 
            this.pnlAnnouncements.BackColor = System.Drawing.Color.Transparent;
            this.pnlAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnnouncements.Location = new System.Drawing.Point(3, 3);
            this.pnlAnnouncements.Name = "pnlAnnouncements";
            this.pnlAnnouncements.Size = new System.Drawing.Size(52, 62);
            this.pnlAnnouncements.TabIndex = 0;
            // 
            // pnlHome
            // 
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(3, 3);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(186, 68);
            this.pnlHome.TabIndex = 0;
            // 
            // tabStatus
            // 
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(986, 496);
            this.tabStatus.TabIndex = 1;
            this.tabStatus.Text = "Status Overview";
            this.tabStatus.UseVisualStyleBackColor = true;
            this.tabStatus.Click += new System.EventHandler(this.ad);
            // 
            // tabSchedule
            // 
            this.tabSchedule.BackColor = System.Drawing.Color.Black;
            this.tabSchedule.Controls.Add(this.calendarSchedule);
            this.tabSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(986, 496);
            this.tabSchedule.TabIndex = 3;
            this.tabSchedule.Text = "View Schedule";
            // 
            // calendarSchedule
            // 
            this.calendarSchedule.BackColor = System.Drawing.Color.Transparent;
            this.calendarSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarSchedule.Location = new System.Drawing.Point(3, 3);
            this.calendarSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.calendarSchedule.Name = "calendarSchedule";
            this.calendarSchedule.Size = new System.Drawing.Size(980, 490);
            this.calendarSchedule.TabIndex = 0;
            // 
            // tabManager
            // 
            this.tabManager.Location = new System.Drawing.Point(4, 22);
            this.tabManager.Name = "tabManager";
            this.tabManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabManager.Size = new System.Drawing.Size(986, 496);
            this.tabManager.TabIndex = 4;
            this.tabManager.Text = "Manager Function";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 496);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Revert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(106, 229);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 69);
            this.textBox7.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mailing Address";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(106, 196);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 159);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 522);
            this.Controls.Add(this.tabs);
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.formMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.formMain_ResizeEnd);
            this.tabs.ResumeLayout(false);
            this.tabCommunication.ResumeLayout(false);
            this.tblLytPostItNote.ResumeLayout(false);
            this.pnlPostItContainer.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.TabPage tabCommunication;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tblLytPostItNote;
        private System.Windows.Forms.Panel pnlPostItContainer;
        private System.Windows.Forms.Panel pnlAnnouncements;
        private System.Windows.Forms.Panel pnlHome;
        private CalendarControl calendarSchedule;
        private System.Windows.Forms.Label lblPostItMessage;
    }
}

