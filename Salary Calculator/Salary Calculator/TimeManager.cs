//*********************************************************************************************
// Programmer:          Óttar Már Halldórsson
// Date:                2015-5-17
// Updated:             2015-6-1
// Project:             Salary Calculator Project
// Class:               TimeManager class holds a list array of the time class.
//                      In this class I put info from time class into the list array 
//                      to keep the data from users input.
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
    public class TimeManager
    {
        private Time m_time = new Time();
        //Declare an object of a collection
        private List<Time> timeSchedule;
        /// <summary>
        /// Constructor
        /// </summary>
        public TimeManager()
        {
            timeSchedule = new List<Time>();
        }

        /// <summary>
        /// Creating a copy of the list collection
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Time GetTimeCopy(int index)
        {
            Time origObj = this.timeSchedule[index];

            Time copyObj = new Time(origObj);
            return copyObj;
        }

        public int Count
        {
            get
            {
                return timeSchedule.Count;
            }
        }
        /// <summary>
        /// Overloaded method to add Schedule
        /// </summary>
        /// <param name="date"></param>
        /// <param name="fixedTime"></param>
        /// <param name="userSchedule"></param>
        /// <param name="salary"></param>
        /// <param name="overTimeSalary"></param>
        /// <param name="timeCalc"></param>
        /// <returns></returns>
        public bool AddSchedule(DateTime date, string fixedTime, int userSchedule, double salary, double overTimeSalary, TimeCalculation timeCalc)
        {
            return AddSchedule(new Time(date, fixedTime, userSchedule, salary, overTimeSalary, timeCalc));
        }
        /// <summary>
        /// Method to add schedules to the registry
        /// </summary>
        /// <param name="timeIn"></param>
        /// <returns></returns>
        public bool AddSchedule(Time timeIn)
        {
            if (timeIn != null)
            {
                //use copy construct
                timeSchedule.Add(new Time(timeIn));
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method to delete a selected schedule in the listbox
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteSchedule(int index)
        {
            if (!(CheckIndexOutOfRange(index)))
            {
                timeSchedule.RemoveAt(index);
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Method to change the selected schedule in the listbox
        /// </summary>
        /// <param name="timeIn"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeSchedule(Time timeIn, int index)
        {
            if (timeIn != null)
            {
                
                timeSchedule.Insert(index, new Time(timeIn));
                timeSchedule.RemoveAt(index + 1);
                
                return true;
            }
            return false;
        }
        /// <summary>
        /// Method to check if schedule contaians a index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndexOutOfRange(int index)
        {
            return (index < 0 || index >= this.timeSchedule.Count);
        }
        /// <summary>
        /// Method that returns an element
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Time GetSchedule(int index)
        {
            if (CheckIndexOutOfRange(index))
            {
                return null;
            }
            else
            {
                return GetTimeCopy(index);
            }
        }
        /// <summary>
        /// Return an array of strings where every string represents a schedule
        /// </summary>
        /// <returns></returns>
        public string[] GetScheduleInfo()
        {
            string[] strInfoStrings = new string[timeSchedule.Count];

            int i = 0;
            foreach (Time timeObj in this.timeSchedule)
            {
                strInfoStrings[i++] = timeObj.ToString();
            }
            return strInfoStrings;
        }

       

      
    }
}
