//*********************************************************************************************
// Programmer:          Óttar Már Halldórsson
// Date:                2015-5-17
// Updated:             2015-6-1
// Project:             Salary Calculator Project
// Class:               TimeCalculations class includes methods with formulas to 
//                      calculate hour time to decimal numbers.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator
{
    public class TimeCalculation
    {
        // initalize variables             
        private int userStartHours;
        private int userStartMinutes;
        private int userEndHours;
        private int userEndMinutes;
        

        /// <summary>
        /// Constructor
        /// </summary>
        public TimeCalculation()
        {
            userStartHours = 0;
            userEndHours = 0;
            userStartMinutes = 0;
            userEndMinutes = 0;
        }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="startHours"></param>
        /// <param name="startMinutes"></param>
        /// <param name="endHours"></param>
        /// <param name="endMinutes"></param>
        public TimeCalculation(int startHours, int startMinutes, int endHours, int endMinutes)
        {
            this.userStartHours = startHours;
            this.userStartMinutes = startMinutes;
            this.userEndHours = endHours;
            this.userEndMinutes = endMinutes;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="otherTimeCalculation"></param>
        public TimeCalculation(TimeCalculation otherTimeCalculation)
        {
            this.userStartHours = otherTimeCalculation.userStartHours;
            this.userStartMinutes = otherTimeCalculation.userStartMinutes;
            this.userEndHours = otherTimeCalculation.userEndHours;
            this.userEndMinutes = otherTimeCalculation.userEndMinutes;
        }

        /// <summary>
        /// Calculation for Start timer
        /// </summary>
        /// <returns></returns>
        public int StartTime(int userStartHours, int userStartMinutes)
        {
            int startTotal;
            userStartHours = userStartHours * 3600;
            userStartMinutes = userStartMinutes * 60;
            startTotal = userStartHours + userStartMinutes;
            return startTotal;
        }
        /// <summary>
        /// Calculation for End timer
        /// </summary>
        /// <returns></returns>
        public int EndTime(int userEndHours, int userEndMinutes)
        {
            int EndTotal;
            userEndHours = userEndHours * 3600;
            userEndMinutes = userEndMinutes * 60;
            EndTotal = userEndHours + userEndMinutes;
            return EndTotal;
        }
        /// <summary>
        /// Formula to convert clock hours to simple number hours
        /// </summary>
        /// <returns></returns>
        public double ConvertTime()
        {
            double totalTime = EndTime(userEndHours, userEndMinutes) - StartTime(userStartHours, userStartMinutes);
            double hours = totalTime / 3600;
            return hours;

        }

        /// <summary>
        /// Get & set method to get users start hours
        /// </summary>
        public int UserStartHours
        {
            get
            {
                return userStartHours;
            }
            set
            {
                if (value >= 0)
                {
                    userStartHours = value;
                }
            }
        }
        /// <summary>
        /// Get & set method to get user start minutes
        /// </summary>
        public int UserStartMinutes
        {
            get
            {
                return userStartMinutes;
            }
            set
            {
                userStartMinutes = value;
            }
        }
        /// <summary>
        /// Get & set method to get user end hours
        /// </summary>
        public int UserEndHours
        {
            get
            {
                return userEndHours;
            }
            set
            {
                userEndHours = value;
            }
        }
        /// <summary>
        /// Get & set method to get user end minutes
        /// </summary>
        public int UserEndMinutes
        {
            get
            {
                return userEndMinutes;
            }
            set
            {
                userEndMinutes = value;
            }
        }
        /// <summary>
        /// Validate users time
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool Validate(out string message)
        {
            message = string.Empty;

            bool ok = (userStartHours >= 0) && (userStartHours < 25) && (userEndHours >= 0) 
                && (userEndHours < 25) && (userStartMinutes < 60) && (userStartMinutes >= 0) 
                && (userEndMinutes >= 0) && (userEndMinutes < 60);
            if (!ok)
                message = "Invalid input";
            return ok;
        } 

    }
}
