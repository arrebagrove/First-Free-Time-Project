//*********************************************************************************************
// Programmer:          Óttar Már Halldórsson
// Date:                2015-5-17
// Updated:             2015-6-1
// Project:             Salary Calculator Project
// Class:               HoursArray class holds each added hours by user.
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
    class HoursArray
    {
        //Declaring array
        private double[] hoursArrays;
        
        /// <summary>
        /// Constructor and creating array object
        /// </summary>
        /// <param name="maxNumOfHours"></param>
        public HoursArray(int maxNumOfHours)
        {
            hoursArrays = new double[maxNumOfHours];
            DefaultValues();
        }
        /// <summary>
        /// Method for max number of salaries
        /// </summary>
        public int MaxNumOfHours
        {
            get { return hoursArrays.Length; }
        }
        /// <summary>
        /// Method to setting the array to default
        /// </summary>
        public void DefaultValues()
        {
            for (int index = 0; index < hoursArrays.Length; index++)
                hoursArrays[index] = 0;
        }
        /// <summary>
        /// Method to find the first empty element in array
        /// </summary>
        /// <returns></returns>
        public int FindFirstElement()
        {
            for (int index = 0; index < hoursArrays.Length; index++)
            {
                if (hoursArrays[index] == 0)
                    return index;
            }
            return -1;
        }
        /// <summary>
        /// Method to ad hours into array
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddHours(double value)
        {
            bool ok = true;

            int index = FindFirstElement();
            if (index >= 0)
            {
                hoursArrays[index] = value;
            }
            return ok;
        }
        /// <summary>
        /// Method to get the total sum of hours
        /// </summary>
        /// <returns></returns>
        public double HoursSum()
        {
            double var = 0;
            var = hoursArrays.Sum();
            return var;
        }
        /// <summary>
        /// Property for the salary array
        /// </summary>
        public double[] HoursArrays
        {
            get
            {
                return hoursArrays;
            }
            set
            {
                hoursArrays = value;
            }
        }
        /// <summary>
        /// Method to check the index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if (index >= 0 && hoursArrays.Length > index)
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Method to get current numer of hours
        /// </summary>
        /// <returns></returns>
        public int GetCurrentNumOfHours()
        {
            int count = 1;
            for (int index = 0; index < hoursArrays.Length; index++)
            {
                if (hoursArrays[index] > 0)
                    count++;
            }
            return count;
        }
    }
}
