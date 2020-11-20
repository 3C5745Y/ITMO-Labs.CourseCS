using System;

namespace ITMO.CScourse.Lab03.WhatDay1
{
    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class WhatDay
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter the year: ");
                string line = Console.ReadLine();
                int yearNum = int.Parse(line);

                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                var DaysInMonths = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                var DaysInLeapMonths = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int maxDayNum = isLeapYear ? 366 : 365;

                //if (isLeapYear)
                //{
                //    Console.WriteLine("IS a leap year");
                //}
                //else
                //{
                //    Console.WriteLine("is NOT a leap year");
                //}

                Console.Write("Please enter a day number between 1 and {0} ", maxDayNum);
                line = Console.ReadLine();
                int dayNum = int.Parse(line);

                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                //Check leap year
                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                    else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    //Check not a leap year
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }

                //if (dayNum <= 31)
                //{ // January
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //if (dayNum <= 28)
                //{ // February
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 28;
                //    monthNum++;
                //}
                //if (dayNum <= 31)
                //{ // March
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //if (dayNum <= 30)
                //{ // April
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}
                //if (dayNum <= 31)
                //{ // May
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //if (dayNum <= 30)
                //{ // June
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}
                //if (dayNum <= 31)
                //{ // July
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //if (dayNum <= 31)
                //{ // August
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //if (dayNum <= 30)
                //{ // September
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}
                //if (dayNum <= 31)
                //{ // October
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //if (dayNum <= 30)
                //{ // November
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 30;
                //    monthNum++;
                //}
                //if (dayNum <= 31)
                //{ // December
                //    goto End;
                //}
                //else
                //{
                //    dayNum -= 31;
                //    monthNum++;
                //}
                //End:

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (System.Exception caught)
            {

                Console.WriteLine(caught);
            }
            Console.ReadKey();
        }
    }
}

