//*********************************************************************************************
// Programmer:          Óttar Már Halldórsson
// Date:                2015-5-17
// Updated:             2015-6-1
// Project:             Salary Calculator Project
// Class:               SalaryArray class holds each added salary by user.
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
    class SalaryArray
    {
        //Declaring array
        private double[] salaryArrays;
        
        /// <summary>
        /// Constructor and creating array object
        /// </summary>
        /// <param name="maxNumOfSalaries"></param>
        public SalaryArray(int maxNumOfSalaries)
        {
            salaryArrays = new double[maxNumOfSalaries];
            DefaultValues();
        }
        /// <summary>
        /// Method for max number of salaries
        /// </summary>
        public int MaxNumOfSalaries
        {
            get { return salaryArrays.Length; }
        }
        /// <summary>
        /// Method to setting array to default
        /// </summary>
        public void DefaultValues()
        {
            for (int index = 0; index < salaryArrays.Length; index++)
                salaryArrays[index] = 0;
        }
        /// <summary>
        /// Method to find the first empty element in array
        /// </summary>
        /// <returns></returns>
        public int FindFirstElement()
        {
            for (int index = 0; index < salaryArrays.Length; index++)
            {
                if (salaryArrays[index] == 0)
                    return index;
            }
            return -1;
        }
        /// <summary>
        /// Method to add salary into array
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddSalary(double value)
        {
            bool ok = true;

            int index = FindFirstElement();

            if (index >= 0)
            {
                salaryArrays[index] = value;
            }
            return ok;
        }
        
        /// <summary>
        /// Method to get the total sum of the array
        /// </summary>
        /// <returns></returns>
        public double SalarySum()
        {
            double var= 0;
            var = salaryArrays.Sum();
            return var;
        }
        /// <summary>
        /// Property for the salary array
        /// </summary>
        public double[] SalaryArrays
        {
            get
            {
                return salaryArrays;
            }
            set
            {
                salaryArrays = value;
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
            if (index >= 0 && salaryArrays.Length > index)
            {
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// Method to get current number of salaries
        /// </summary>
        /// <returns></returns>
        public int GetCurrentNumOfSalaries()
        {
            int count = 1;
            for (int index = 0; index < salaryArrays.Length; index++)
            {
                if (salaryArrays[index] > 0)
                    count++;
            }
            return count;
        }

    }
}
