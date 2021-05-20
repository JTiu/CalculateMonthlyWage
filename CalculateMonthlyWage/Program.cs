using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMonthlyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 4000;
            int months = 12;
            int monthlyWage2 = 5000;
            int monthlyWage3 = 6000;
            int daysInMonth = 30;
            int hoursInDay = 8;


           
            CalculateYearlyWage(monthlyWage, months);
            CalculateDaysInYear(months, daysInMonth);
            AddBonusYearlyWage(monthlyWage, months);
            CalculateYearlyWage(monthlyWage2, months);
            AddBonusYearlyWage(monthlyWage2, months);
            CalculateYearlyWage(monthlyWage3, months);
            AddBonusYearlyWage(monthlyWage3, months);
            int hoursInYear = CalculateHoursInYear(hoursInDay, months, daysInMonth);
            Console.WriteLine($"hours in year {hoursInYear}");
            Console.ReadLine();
        }
        //simple call of method, void
        public static void CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
        }
        public static void CalculateDaysInYear (int daysInMonth, int months)
        {
            Console.WriteLine($"Days in Year: {daysInMonth * months}");
        }
        //method with a return of an INT
        public static int CalculateHoursInYear(int hoursInDay, int daysInMonth, int months)
        {
            return hoursInDay * daysInMonth * months;
        }
        public static void AddBonusYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            Console.WriteLine($"Yearly wage plus bonus: {monthlyWage * numberOfMonthsWorked + 97}");
            Console.ReadLine();
        }
    }
}
