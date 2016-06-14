//*********************************************************************************************
// Programmer:          Óttar Már Halldórsson
// Date:                2015-5-17
// Updated:             2015-6-7
// Project:             Salary Calculator Project
// Class:               MainForm class gets information from all the classes and put it 
//                      out in the GUI. The GUI is build in this class.
// About:               This program is for use of calculating salary for certain
//                      group of employees. User puts in their salary and overtime salary.
//                      They all have four different schedules to choose from and/or if
//                      they want to change certain days. The program then calculates
//                      the hours and salary for them. After 133 hours worked they get
//                      extra salary which is called "Performance" hours.
//                      At the bottom of the program they can see number of days worked,
//                      total salary and total hours of both regular and performanced.
//********************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Salary_Calculator
{
    public partial class MainForm : Form
    {
        private const int maxNumOfSalaries = 50;
        private const int maxNumOfHours = 50;
        private TimeManager timeMngr;               //contact registry
        private Time time = new Time();             
        private TimeCalculation timeCalc;
        private SalaryArray salary = new SalaryArray(maxNumOfSalaries);     //Array
        private HoursArray hours = new HoursArray(maxNumOfHours);           //Array
        
        
        public MainForm()
        {
            InitializeComponent();
            //Create an instance of the schedule registry
            
            InitializeGUI();

        }
        //Empty the textboxes and add date timer
        private void InitializeGUI()
        {
            this.hours = new HoursArray(maxNumOfHours);
            this.timeMngr = new TimeManager();
            this.salary = new SalaryArray(maxNumOfSalaries);
            //Textboxes empty
            txtStartHours.Text = string.Empty;
            txtEndHours.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtOverTimeSalary.Text = string.Empty;
            ShowToolTips();    
            //Format dateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            //Make all labels empty
            lblCount.Text = string.Empty;
            lblTotalHoursDisplay.Text = string.Empty;
            lblSalaryDisplay.Text = string.Empty;
            lblPerfHoursDisplay.Text = string.Empty;
            lblTotalSalaryPerfDisplay.Text = string.Empty;
            lblTotalSalaryDisplay.Text = string.Empty;
            lblTotalSalaryNetDisplay.Text = string.Empty;
            //Assign hotkeys for new and exit menu items
            SetupNewMenuItem();
            SetupExitMenuItem();
            //Clear listbox
            lstResult.Items.Clear();
            
          
           
        }
        /// <summary>
        /// Clears listbox and calls the method GetScheduleInfo of time schedules
        /// </summary>
        private void UpdateGUI()
        {
            string[] strTime = timeMngr.GetScheduleInfo();
            
            if (strTime != null)
            {
                lstResult.Items.Clear();
                lstResult.Items.AddRange(this.timeMngr.GetScheduleInfo());
                lblCount.Text = lstResult.Items.Count.ToString();
                lblSalaryDisplay.Text = salary.SalarySum().ToString("00,0.0");
                lblTotalHoursDisplay.Text = hours.HoursSum().ToString("F");
                lblPerfHoursDisplay.Text = ShowPerfHours().ToString("F");
                lblTotalSalaryPerfDisplay.Text = ShowPerfSalary().ToString("00,0.0");
                lblTotalSalaryDisplay.Text = ShowTotalSalary().ToString("00,0.0");
                lblTotalSalaryNetDisplay.Text = ShowSalaryNet().ToString("00,0.0");
                
            }
        }
        /// <summary>
        /// Show Tooltips for textboxes and datetimer
        /// </summary>
        private void ShowToolTips()
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(txtSalary, "Write Your Hourly Wage");
            toolTip1.SetToolTip(txtOverTimeSalary, "Write Your Hourly Overtime Wage");
            toolTip1.SetToolTip(dateTimePicker1, "Select The Date To Add");
            toolTip1.SetToolTip(txtStartHours, "Write The Hour You Started In 24 Hour Format, ex. 08 or 16");
            toolTip1.SetToolTip(txtStartMinutes, "Write The Minute You Started, ex 30");
            toolTip1.SetToolTip(txtEndHours, "Write The Hour You Ended In 24 Hour Format, ex 08 or 16");
            toolTip1.SetToolTip(txtEndMinutes, "Write The Minute You Ended, ex 30");
            toolTip1.SetToolTip(rbnChangeTime, "Used To Add Custom Time");
        }
        /// <summary>
        /// Read salary and schedule choices info. 
        /// Validates salary boxes
        /// </summary>
        /// <returns></returns>
        private bool ReadInput()
        {
            time = new Time();     
            ReadAndValidateSalary();
            ReadUserScheduleChoice();
            time.Date = dateTimePicker1.Value;
            string message;
            bool shown = false;     //flag
            bool ok = time.Validate(out message);
            if (ok)
            {
            }
            else
            {
                if (!shown)
                {
                    shown = true;
                    string strMessage = "Salary and Overtime boxes are empty";
                    MessageBox.Show(strMessage, "Error");
                }
                
            }
            return ok;

        }
        /// <summary>
        /// Reads change time info and validates
        /// </summary>
        /// <returns></returns>
        private bool ReadInputTime()
        {
            timeCalc = new TimeCalculation();
            time.TimeCalcData = timeCalc;
            ReadAndValidateTime();

            string message;
            bool ok = timeCalc.Validate(out message);
            if (ok)
            {
            }
            else
            {
                string strMessage = "Set/Change time is invalid";
                MessageBox.Show(strMessage, "Error");
            }
            return ok;
        }
        /// <summary>
        /// Read and validate time
        /// </summary>
        /// <returns></returns>
        private bool ReadAndValidateTime()
        {
            
            int intValue = 0;
            if (int.TryParse(txtStartHours.Text, out intValue))
            {
                timeCalc.UserStartHours = intValue;
            }
            else
                return false;

            int intValue1 = 0;
            if (int.TryParse(txtEndHours.Text, out intValue1))
            {
                timeCalc.UserEndHours = intValue1;
            }
            else
                return false;

            int intValue2 = 0;
            if (int.TryParse(txtStartMinutes.Text, out intValue2))
            {
                timeCalc.UserStartMinutes = intValue2;
            }
            else
                return false;

            int intValue3 = 0;
            if (int.TryParse(txtEndMinutes.Text, out intValue3))
            {
                timeCalc.UserEndMinutes = intValue3;
            }
            else
                return false;
		  


            string errMessage = string.Empty;
            if (!timeCalc.Validate(out errMessage))
            {
                MessageBox.Show(errMessage, "Error");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Read and validate salary
        /// </summary>
        /// <returns></returns>
        private bool ReadAndValidateSalary()
        {
            double dblValue = 0.0;
            if (double.TryParse(txtSalary.Text, out dblValue))
            {
                time.UserSalary = dblValue;
            }
            else
                return false;

            double dblValue1 = 0.0;
            if (double.TryParse(txtOverTimeSalary.Text, out dblValue1))
            {
                time.UserOverTimeSalary = dblValue1;
            }
            else
                return false;

            string errMessage = string.Empty;
            if (!time.Validate(out errMessage))
            {
                MessageBox.Show(errMessage, "Error");
                return false;
            }
            return true;

        }
        /// <summary>
        /// Read and validate schedule choices
        /// </summary>
        /// <returns></returns>
        private bool ReadUserScheduleChoice()
        {
            if (rbnFirstShift.Checked)
            {
                time.UserSchedule = 1;
            }
            else if (rbnSecondShift.Checked)
            {
                time.UserSchedule = 2;
            }
            else if (rbnThirdShift.Checked)
            {
                time.UserSchedule = 3;
            }
            else if (rbnFourthShift.Checked)
            {
                time.UserSchedule = 4;
            }
            else if (rbnChangeTime.Checked)
            {
                time.UserSchedule = 5;
            }
                

            return true;

        }
        /// <summary>
        /// Helper method to show performanced hours
        /// </summary>
        /// <returns></returns>
        private double ShowPerfHours()
        {
            double performanceHours;
            double perfValue = 133;     
            performanceHours = hours.HoursSum() - perfValue;
            if (performanceHours < 0)
            {
                return 0;
            }
            else
            return performanceHours;
        }
        /// <summary>
        /// Helper method to show performance hours salary
        /// Performance hours calculated, after 133 hours typed in, salary raises by 8%
        /// </summary>
        /// <returns></returns>
        private double ShowPerfSalary()
        {
            double perfHoursPercent = 0.08;
            double perfSalary;
            ShowPerfHours();
            
                perfSalary = ShowPerfHours() * (time.UserSalary * perfHoursPercent);
                return perfSalary;
        }   
        /// <summary>
        /// Show Total salary for the label
        /// </summary>
        /// <returns></returns>
        private double ShowTotalSalary()
        {
            double totalSalary;
            totalSalary = ShowPerfSalary() + salary.SalarySum();
            return totalSalary;
        }
        /// <summary>
        /// Show Total salary with net
        /// </summary>
        /// <returns></returns>
        private double ShowSalaryNet()
        {
            double totalSalaryNet;
            double salaryTaxes = 0.78;
            totalSalaryNet = ShowTotalSalary() * salaryTaxes;
            return totalSalaryNet;
        }
        /// <summary>
        /// Button add, adds the users input to the to listbox and timeManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {   
            if (ReadInput() && ReadInputTime())
            {
                if (timeMngr.AddSchedule(time))
                    hours.AddHours(time.CalculateHours());
                    salary.AddSalary(time.SalaryCalc());  
                    UpdateGUI();          
            }
        }
        /// <summary>
        /// Method to check if items in listbox are selected
        /// </summary>
        /// <returns></returns>
        private bool CheckSelectedIndex()
        {
            return (lstResult.SelectedIndex >= 0);
        }
        /// <summary>
        /// Method to return selected items in listbox
        /// </summary>
        /// <returns></returns>
        private int GetSelectedIndex()
        {
            return lstResult.SelectedIndex;
        }
        /// <summary>
        /// Button to delete item in listbox and in time manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GetSelectedIndex() == -1)           //If no date is selected, comes error message
            {
                string strMessage = "No Date Selected";
                MessageBox.Show(strMessage);
            }
            else
            {
                if (CheckSelectedIndex() && timeMngr.DeleteSchedule(GetSelectedIndex()))
                for (int i = GetSelectedIndex(); i < salary.SalaryArrays.GetUpperBound(0) - 1; i++)
                {
                    salary.SalaryArrays[i] = salary.SalaryArrays[i + 1];
                }

                for (int i = GetSelectedIndex(); i < hours.HoursArrays.GetUpperBound(0) - 1; i++)
                {
                    hours.HoursArrays[i] = hours.HoursArrays[i + 1];
                }
                UpdateGUI();
            }
        }
        /// <summary>
        /// Button to change item in listbox and in time manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (CheckSelectedIndex() && ReadInput() && ReadInputTime())
            {
                for (int i = GetSelectedIndex(); i < salary.SalaryArrays.GetUpperBound(0) - 1; i++)
                {
                    salary.SalaryArrays[i] = salary.SalaryArrays[i + 1];
                    
                }
                for (int i = GetSelectedIndex(); i < hours.HoursArrays.GetUpperBound(0) - 1; i++)
                {
                    hours.HoursArrays[i] = hours.HoursArrays[i + 1];
                }
                hours.AddHours(time.CalculateHours());
                salary.AddSalary(time.SalaryCalc());
                if (timeMngr.ChangeSchedule(time, GetSelectedIndex()))
                UpdateGUI();
            }
        }
        /// <summary>
        /// Method to make a new menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }
        /// <summary>
        /// Assign hotkey for new menu item
        /// </summary>
        private void SetupNewMenuItem()
        {
            newMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newMenuItem.ShowShortcutKeys = true;
        }
        /// <summary>
        /// Assign hotkey for exit menu item
        /// </summary>
        private void SetupExitMenuItem()
        {
            exitMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitMenuItem.ShowShortcutKeys = true;
        }
        /// <summary>
        /// Method to check if user really wants to exit program with exit menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            string textOut = "Are you sure you want to Exit?";
            DialogResult buttonClicked = MessageBox.Show(textOut, "Are You Sure?", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);
            switch (buttonClicked)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.No:
                    break;
            }
        }
        /// <summary>
        /// Show aboutbox and activate about menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About();
            aboutBox.Show();
        }
        /// <summary>
        /// Idea of this method was to add whole workweek, so if user puts in monday
        /// the rest of the days will add up. It is working almost as intended but
        /// the dates wont change. Ive tried few ideas of how to make it work but had no luck.
        /// Will be ready for next update ! 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddWeek_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 5; i++)
            {
                DateTime today = DateTime.Now;                  //start day
                DateTime lastDay = DateTime.Now.AddDays(5);     //end day, is it possible to assign to friday?
                if (ReadInput() && ReadInputTime())
                {
                    if (timeMngr.AddSchedule(time))
                        for (DateTime d = today; d <= lastDay; d = d.AddDays(1))    //tried for loop to assign days to datetime
                        {
                            time.Date = d;
                        }
                        hours.AddHours(time.CalculateHours());
                        salary.AddSalary(time.SalaryCalc());
                        UpdateGUI();
                        
                }
            }

        }
        /// <summary>
        /// Method to assign close button to pop up with messagebox to check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit application?",
              "Exit?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        

       
    }
}
