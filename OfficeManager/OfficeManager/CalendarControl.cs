using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using OfficeManager.Forms;
using System.Windows;

namespace OfficeManager
{
    public partial class CalendarControl : UserControl
    {
        private formSchedule scheduler;
        private Dictionary<String, Label> timeLabels;
        private ArrayList stringTimes;

        public CalendarControl()
        {
            Label temp;
            InitializeComponent();

            timeLabels = new Dictionary<String, Label>();
            stringTimes = new ArrayList();
            TableLayoutPanelCellPosition cell = new TableLayoutPanelCellPosition();
            cell.Column = 0;

            Color darkblue = ColorTranslator.FromHtml("#024769");
            Color lightblue = ColorTranslator.FromHtml("#95CBE9");
            Color darkgreen = ColorTranslator.FromHtml("#2C5700");
            Color lightgreen = ColorTranslator.FromHtml("#AFD775");
            Color brown = ColorTranslator.FromHtml("#EFD279");
            Color pink = ColorTranslator.FromHtml("#DE9D7F");

            for (int i = 600, j = 2; i < 2100; i += 50, j++)
            {
                stringTimes.Add("" + i);

                temp = new Label();
                //Change temp properties here
                temp.BackColor = darkblue;
                temp.ForeColor = lightblue;
                temp.Text = get12HourFormat(i);
                temp.AutoSize = false;

                
                temp.Dock = DockStyle.Fill;
                cell.Row = j;

                tblLayoutCalendar.Controls.Add(temp);
                tblLayoutCalendar.SetCellPosition(temp, cell); 
                timeLabels.Add(i + "", temp);
            }



            //Put time labels in correct place

            tblLayoutCalendar.BackColor = darkblue;

            label1.BackColor = darkgreen;
            label1.ForeColor = lightgreen;

            label2.BackColor = lightgreen;
            label2.ForeColor = darkgreen;

            lblTime.ForeColor = darkblue;
            lblTime.BackColor = lightblue;
        }

        private void lblS6_Click(object sender, EventArgs e)
        {
            scheduler = new Forms.formSchedule(this);
            scheduler.ShowDialog();
        }

        public void SaveClickEvent(double startTime, double endTime)
        {
            scheduler.Close();
        }

        private String get12HourFormat(int time)
        {
            StringBuilder result = new StringBuilder();
            
            String end = " AM";
            int hour = time / 100;
            String minute = ":00";

            if (time >= 1200)
            {
                end = " PM";
            }
            if (time >= 1300)
            {
                hour -= 12;
            }

            if (time % 100 == 50)
            {
                minute = ":30";
            }

            result.Append(hour);
            result.Append(minute);
            result.Append(end);

            return result.ToString();
        }
    
    }
}
