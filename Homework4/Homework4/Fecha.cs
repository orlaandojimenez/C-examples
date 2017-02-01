using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Fecha
    {

       

        private int day;
        private int month;
        private int year;
        
        /// <summary>
        /// Main Constructor 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <param name="y"></param>
        public Fecha(int d, int m, int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;

        }

        private bool isLeepYear(int year)
        {
            bool isLeep = false;
            if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
            {
                isLeep = true;
            }
            else if (year % 4 == 0)
            {
                isLeep = true;
            }
            return isLeep;

        }

        private bool has31(int month)
        {
            bool has31 = false;
            if(month == 1 || month == 3 || month == 5 || month == 7
                || month == 8 || month == 10 || month == 12)
            {
                has31 = true;
            }
            return has31;
        }

        private bool has30(int month)
        {
            bool has30 = false;
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                has30 = true;
            }
            return has30;
        }

        public string FechaString
        {
            get { string dateFormated = "Here comes the date: " 
                + this.day + "-" + this.month + "-" + this.year;

            if (this.isLeepYear(this.year))
            {
                if (this.month == 2)
                {
                    if (day > 29)
                    {
                        string errorleep = "Error: This year is a leep, February only has 29 days";
                        return errorleep;
                    }
                }
            }
            else
            {
                if (this.month == 2)
                {
                    if (day > 28)
                    {
                        string errorfeb = "Error: This month only has 28 days";
                        return errorfeb;
                    }
                }
            }
            if (this.has31(this.month))
            {
                if (this.day > 31)
                {
                    string error31 = "Error: This month only has 31 days";
                    return error31;
                }
            }
            if (this.has30(this.month))
            {
                string error30 = "Error: This month only has 30 days";
                return error30;
            }

            return dateFormated;
            }
        }
    }
}
