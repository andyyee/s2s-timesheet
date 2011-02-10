namespace OfficeManager
{
    partial class CalendarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalendarGrid = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CalendarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CalendarGrid
            // 
            this.CalendarGrid.AllowUserToAddRows = false;
            this.CalendarGrid.AllowUserToDeleteRows = false;
            this.CalendarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalendarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Sunday,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
            this.CalendarGrid.Location = new System.Drawing.Point(0, 0);
            this.CalendarGrid.Name = "CalendarGrid";
            this.CalendarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CalendarGrid.Size = new System.Drawing.Size(689, 257);
            this.CalendarGrid.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.Width = 55;
            // 
            // Sunday
            // 
            this.Sunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sunday.Width = 68;
            // 
            // Monday
            // 
            this.Monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Monday.HeaderText = "Monday";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Width = 70;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Tuesday.HeaderText = "Tuesday";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tuesday.Width = 73;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Wednesday.Width = 89;
            // 
            // Thursday
            // 
            this.Thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Thursday.Width = 76;
            // 
            // Friday
            // 
            this.Friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Friday.HeaderText = "Friday";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Friday.Width = 60;
            // 
            // Saturday
            // 
            this.Saturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Saturday.Width = 74;
            // 
            // CalendarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CalendarGrid);
            this.Name = "CalendarControl";
            this.Size = new System.Drawing.Size(755, 333);
            ((System.ComponentModel.ISupportInitialize)(this.CalendarGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CalendarGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
    }
}
