using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

/**
 * This form is a pop up for use with the CalendarControl.
 * The user selected times from this dialog box.
 * */
namespace OfficeManager.Forms
{
    public partial class formSchedule : Form
    {
        private time[] startTimes, endTimes;
        private CalendarControl parent;

        /**
         * Struct to hold all of the available time choices
         * Values are stored as increasing doubles where .5 means a half hour
         * ex. 13.5 means 1:30 PM
         * */
        public struct time
        {
            private string _key;
            private double _value;

            public time(string key, double value)
            {
                this._value = value;
                this._key = key;
            }

            public string key { 
                get 
                { return this._key; 
                } }

            public double value{ 
                get 
                { return this._value; 
                } }

            public override string ToString()
            {
                return this._value + "";
            }
        }

        /**
         * Constructor
         * Must be passed the CalendarControl that opened the form in order to send back the times
         * TODO: Be passed in the selected start time.
         * */
        public formSchedule(CalendarControl parent)
        {
            this.parent = parent;
            InitializeComponent();

            startTimes = new time[] {
                new time("6:00 AM" , 6),
                new time("6:30 AM" , 6.5),
                new time("7:00 AM" , 7),
                new time("7:30 AM" , 7.5),
                new time("8:00 AM" , 8),
                new time("8:30 AM" , 8.5),
                new time("9:00 AM" , 9),
                new time("9:30 AM" , 9.5),
                new time("10:00 AM" , 10),
                new time("10:30 AM" , 10.5),
                new time("11:00 AM" , 11),
                new time("11:30 AM" , 11.5),
                new time("12:00 AM" , 12),
                new time("12:30 PM" , 12.5),
                new time("1:00 PM" , 13),
                new time("1:30 PM" , 13.5),
                new time("2:00 PM" , 14),
                new time("2:30 PM" , 14.5),
                new time("3:00 PM" , 15),
                new time("3:30 PM" , 15.5),
                new time("4:00 PM" , 16),
                new time("4:30 PM" , 16.5),
                new time("5:00 PM" , 17),
                new time("5:30 PM" , 17.5),
                new time("6:00 PM" , 18),
                new time("6:30 PM" , 18.5),
                new time("7:00 PM" , 19.5),
                new time("7:30 PM" , 19.5),
                new time("8:00 PM" , 20)
            };            
            
            endTimes = new time[29];
            for(int i = 0; i < 29; i++)
            {
                endTimes[i] = startTimes[i];
            }
        }

        private void formSchedule_Load(object sender, EventArgs e)
        {
            comboBoxStart.DataSource = startTimes;
            comboBoxStart.DisplayMember = "key";
            comboBoxStart.ValueMember = "value";

            comboBoxEnd.DataSource = endTimes;
            comboBoxEnd.DisplayMember = "key";
            comboBoxEnd.ValueMember = "value";
        }

        private void comboBoxStart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEnd.SelectedValue != null)
            {
                if (double.Parse(comboBoxStart.SelectedValue + "") > 
                    double.Parse(comboBoxEnd.SelectedValue + "") )
                {
                    errorTime.SetError(grpBoxTimeSlot, "Start time is after end time");
                }
                else
                {
                    errorTime.SetError(grpBoxTimeSlot, "");
                }
            }
        }

        private void comboBoxEnd_SelectedValueChanged(object sender, EventArgs e)
        {

            if (double.Parse(comboBoxStart.SelectedValue + "") >
                double.Parse(comboBoxEnd.SelectedValue + ""))
            {
                errorTime.SetError(grpBoxTimeSlot, "End time is before start time");
            }
            else
            {
                errorTime.SetError(grpBoxTimeSlot, "");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(errorTime.GetError(grpBoxTimeSlot).Equals(""))
            {
                parent.SaveClickEvent(
                    double.Parse(comboBoxStart.SelectedValue + ""), 
                    double.Parse(comboBoxEnd.SelectedValue + ""));
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
