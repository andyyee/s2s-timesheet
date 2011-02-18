namespace OfficeManager.Forms
{
    partial class formSchedule
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxStart = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.comboBoxEnd = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBoxTimeSlot = new System.Windows.Forms.GroupBox();
            this.errorTime = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBoxTimeSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStart
            // 
            this.comboBoxStart.AccessibleDescription = "comboBoxEnd";
            this.comboBoxStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStart.FormattingEnabled = true;
            this.errorTime.SetIconPadding(this.comboBoxStart, 2);
            this.comboBoxStart.Location = new System.Drawing.Point(67, 23);
            this.comboBoxStart.Name = "comboBoxStart";
            this.comboBoxStart.Size = new System.Drawing.Size(75, 21);
            this.comboBoxStart.TabIndex = 0;
            this.comboBoxStart.SelectedValueChanged += new System.EventHandler(this.comboBoxStart_SelectedValueChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(6, 26);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(6, 63);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 2;
            this.lblEnd.Text = "End";
            // 
            // comboBoxEnd
            // 
            this.comboBoxEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnd.Location = new System.Drawing.Point(67, 60);
            this.comboBoxEnd.Name = "comboBoxEnd";
            this.comboBoxEnd.Size = new System.Drawing.Size(75, 21);
            this.comboBoxEnd.TabIndex = 3;
            this.comboBoxEnd.SelectedValueChanged += new System.EventHandler(this.comboBoxEnd_SelectedValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpBoxTimeSlot
            // 
            this.grpBoxTimeSlot.Controls.Add(this.comboBoxEnd);
            this.grpBoxTimeSlot.Controls.Add(this.lblEnd);
            this.grpBoxTimeSlot.Controls.Add(this.lblStart);
            this.grpBoxTimeSlot.Controls.Add(this.comboBoxStart);
            this.grpBoxTimeSlot.Location = new System.Drawing.Point(12, 41);
            this.grpBoxTimeSlot.Name = "grpBoxTimeSlot";
            this.grpBoxTimeSlot.Size = new System.Drawing.Size(179, 104);
            this.grpBoxTimeSlot.TabIndex = 6;
            this.grpBoxTimeSlot.TabStop = false;
            this.grpBoxTimeSlot.Text = "Time Slot";
            // 
            // errorTime
            // 
            this.errorTime.ContainerControl = this;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 13);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(108, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Editing Schedule for: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(113, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "NAME";
            // 
            // formSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 223);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.grpBoxTimeSlot);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "formSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Work Hours";
            this.Load += new System.EventHandler(this.formSchedule_Load);
            this.grpBoxTimeSlot.ResumeLayout(false);
            this.grpBoxTimeSlot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.ComboBox comboBoxEnd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBoxTimeSlot;
        private System.Windows.Forms.ErrorProvider errorTime;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
    }
}