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
    public partial class CalendarControl2 : UserControl
    {
        //private formSchedule scheduler;
        private Dictionary<String, Label> timeLabels;
        private Label[] dateLabels = new Label[7];
        private ArrayList stringTimes;

        public CalendarControl2()
        {
            Label temp;
            InitializeComponent();
            InitializeDateLabels();
            
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

            for (int i = 600, j = 2; i <= 2100; i += 50, j++)
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

            label3.BackColor = darkgreen;
            label3.ForeColor = lightgreen;

            lblTime.ForeColor = darkblue;
            lblTime.BackColor = lightblue;
        }

        private void lblS6_Click(object sender, EventArgs e)
        {
            //scheduler = new Forms.formSchedule(this);
            //scheduler.ShowDialog();
        }

        public void SaveClickEvent(double startTime, double endTime)
        {
            //scheduler.Close();
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

        private void InitializeDateLabels()
        {
            dateLabels[0] = lblSundayDate;
            dateLabels[1] = lblMondayDate;
            dateLabels[2] = lblTuesdayDate;
            dateLabels[3] = lblWednesdayDate;
            dateLabels[4] = lblThursdayDate;
            dateLabels[5] = lblFridayDate;
            dateLabels[6] = lblSaturdayDate;
            DateTime now = DateTime.Today;
            now = now.Subtract(TimeSpan.FromDays((int)now.DayOfWeek));
            for (int i = 0; i < 7; i++)
            {
                dateLabels[i].Text = now.ToShortDateString();
                now = now.AddDays(1);
            }
        }

        private void tblLayoutCalendar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblLayoutCalendar_Paint_1(object sender, PaintEventArgs e)
        {

        }
            
    }
}
