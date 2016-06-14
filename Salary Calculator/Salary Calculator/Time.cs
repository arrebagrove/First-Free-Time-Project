//*****************************************************************************************
// Programmer:          Óttar Már Halldórsson
// Date:                2015-5-17
// Updated:             2015-6-6
// Project:             Salary Calculator Project
// Class:               Time class holds the users data and has methods to calculate salary,
//                      hours and holds the shift schedules.
// About:               This program is for use of calculating salary for certain
//                      group of employees. User puts in their salary and overtime salary.
//                      They all have four different schedules to choose from and/or if
//                      they want to change certain days. The program then calculates
//                      the hours and salary for them. After 133 hours worked they get
//                      extra salary which is called "Performance" hours.
//                      At the bottom of the program they can see number of days worked,
//                      total salary and total hours of both regular and performanced.
//*****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Salary_Calculator
{
    public class Time
    {
        //Initalize variables
        private DateTime date;
        private string fixedTime;        
        private int userSchedule;
        private double salary;
        private double overTimeSalary;
        private TimeCalculation timeCalc;
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Time()
        {
            salary = 0.0;
            overTimeSalary = 0.0;
            timeCalc = new TimeCalculation();
            date = DateTime.Now;
            
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="date"></param>
        /// <param name="fixedTime"></param>
        /// <param name="userSchedule"></param>
        /// <param name="salary"></param>
        /// <param name="overTimeSalary"></param>
        /// <param name="timeCalc"></param>
        public Time(DateTime date, string fixedTime, int userSchedule,
            double salary, double overTimeSalary, TimeCalculation timeCalc)
        {
            
            this.timeCalc = new TimeCalculation(timeCalc);   
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="theOther"></param>
        public Time(Time theOther)
        {
            this.date = theOther.date;
            this.fixedTime = theOther.fixedTime;
            
            this.userSchedule = theOther.userSchedule;
            this.salary = theOther.salary;
            this.overTimeSalary = theOther.overTimeSalary;
            this.timeCalc = theOther.timeCalc;
        }

        /// <summary>
        /// Property to get and set TimeCalculation class data
        /// </summary>
        public TimeCalculation TimeCalcData
        {
            get
            {
                return timeCalc;
            }
            set
            {
                timeCalc = value;
            }
        }
        /// <summary>
        /// Property to get and set date
        /// </summary>
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        /// <summary>
        /// First shift that user can choose
        /// </summary>
        /// <returns> string with the time of shift 08:15 - 16:45 </returns>
        public string FirstShiftTime()
        {
            timeCalc.UserStartHours = 08;
            timeCalc.UserStartMinutes = 15;
            timeCalc.UserEndHours = 16;
            timeCalc.UserEndMinutes = 45;

            fixedTime = timeCalc.UserStartHours.ToString("00") + ":" + timeCalc.UserStartMinutes.ToString("00")
                + " - " + timeCalc.UserEndHours.ToString("00") + ":" + timeCalc.UserEndMinutes.ToString("00");
            
            return fixedTime;
        }
        /// <summary>
        /// Second shift that user can choose
        /// </summary>
        /// <returns> string with the time of shift 09:00 - 17:30 </returns>
        public string SecondShiftTime()
        {
            timeCalc.UserStartHours = 09;
            timeCalc.UserStartMinutes = 00;
            timeCalc.UserEndHours = 17;
            timeCalc.UserEndMinutes = 30;

            fixedTime = timeCalc.UserStartHours.ToString("00") + ":" + timeCalc.UserStartMinutes.ToString("00")
                + " - " + timeCalc.UserEndHours.ToString("00") + ":" + timeCalc.UserEndMinutes.ToString("00");
            return fixedTime;
        }
        /// <summary>
        /// Third shift that user can choose
        /// </summary>
        /// <returns> string with the time of shift 09:30 - 18:00 </returns>
        public string ThirdShiftTime()
        {
            timeCalc.UserStartHours = 09;
            timeCalc.UserStartMinutes = 30;
            timeCalc.UserEndHours = 18;
            timeCalc.UserEndMinutes = 00;

            fixedTime = timeCalc.UserStartHours.ToString("00") + ":" + timeCalc.UserStartMinutes.ToString("00")
                + " - " + timeCalc.UserEndHours.ToString("00") + ":" + timeCalc.UserEndMinutes.ToString("00");
            return fixedTime;
        }
        /// <summary>
        /// Fourth shift that user can choose
        /// </summary>
        /// <returns> string with the time of shift 10:30 - 19:00 </returns>
        public string FourthShiftTime()
        {
            timeCalc.UserStartHours = 10;
            timeCalc.UserStartMinutes = 30;
            timeCalc.UserEndHours = 19;
            timeCalc.UserEndMinutes = 00;

            fixedTime = timeCalc.UserStartHours.ToString("00") + ":" + timeCalc.UserStartMinutes.ToString("00")
                + " - " + timeCalc.UserEndHours.ToString("00") + ":" + timeCalc.UserEndMinutes.ToString("00");
            return fixedTime;
        }
        /// <summary>
        /// Shift that user can set the time by himself through textboxes
        /// </summary>
        /// <returns> string with users time </returns>
    
        public string ChangeShiftTime()
        {
            
            fixedTime = timeCalc.UserStartHours.ToString("00") + ":" + timeCalc.UserStartMinutes.ToString("00")
                + " - " + timeCalc.UserEndHours.ToString("00") + ":" + timeCalc.UserEndMinutes.ToString("00");
            return fixedTime;
        }
        /// <summary>
        /// Method to calculate the hours of the shift
        /// </summary>
        /// <returns></returns>
        public double CalculateHours()
        {
            DecideUserSchedule();       //User choice from the radiobuttons
            double lunchBreak = 0.75;   //Lunch break taking of hours  
            double friday = 0.25;       //on friday they work shorter
            double total;
            if (date.DayOfWeek == DayOfWeek.Friday)
            {
                double fridayTotal = timeCalc.ConvertTime() - lunchBreak - friday;
                return fridayTotal;
            }
            else
            total = timeCalc.ConvertTime() - lunchBreak;

            return total;
        }
        /// <summary>
        /// Method that radiobuttons decide which schedule the user is selecting
        /// The choice is forwarded to deciding shift method, and then calculated.
        /// </summary>
        /// <returns></returns>
        public string DecideUserSchedule()
        {
            
            if (userSchedule == 1)
            {
               return FirstShiftTime();
            }
            else if (userSchedule == 2)
            {
                return SecondShiftTime();
            }
            else if (userSchedule == 3)
            {
                return ThirdShiftTime();
            }
            else if (userSchedule == 4)
            {
                return FourthShiftTime();
            }
            else if (userSchedule == 5)
            {
                return ChangeShiftTime();
            }
            return string.Empty;
        }
        /// <summary>
        /// Calculating salary, only on fourth shift there is always 1 hour in overtime because they work till 19:00.
        /// Otherwise they dont work overtime. 
        /// </summary>
        /// <returns></returns>
        public double SalaryCalc()
        {
            double time;
            double overTime;

            if (userSchedule == 4)
            {
                overTime = CalculateHours() * salary - salary + overTimeSalary;
                return overTime;
            }

            else
                time = CalculateHours() * salary;
                return time;
        }

        /// <summary>
        /// Get and set user schedule
        /// </summary>
        public int UserSchedule
        {
            get
            {
                return userSchedule;
            }
            set
            {
                userSchedule = value;
            }
        }
        /// <summary>
        /// Property to get and set fixed time
        /// </summary>
        public string FixedTime
        {
            get
            {
                return fixedTime;
            }
            set
            {
                fixedTime = value;
            }
        }
        /// <summary>
        /// Property to get and set user salary
        /// </summary>
        public double UserSalary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        /// <summary>
        /// property to get and set user overtime salary
        /// </summary>
        public double UserOverTimeSalary
        {
            get
            {
                return overTimeSalary;
            }
            set
            {
                overTimeSalary = value;
            }
        }
        /// <summary>
        /// Method to validate user salary and overtime salary
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Validate(out string message)
        {
           message = string.Empty;

           bool ok = (salary > 0) && (overTimeSalary > 0);
           if (!ok)
               message = "Salary and Overtime cannot be negative";
           return ok;
        }
        /// <summary>
        /// ToString method to display in listbox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           
           string strOut = string.Format("{0} {1, 15} {2, 11} {3, 14}", Date.ToString("ddd dd/MM/yyyy"), DecideUserSchedule(), CalculateHours().ToString("F"), SalaryCalc().ToString("F"));
           return strOut;
        }
    }
}
