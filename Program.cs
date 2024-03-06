using static System.Console;

namespace CalculateWeeklyWage
{
    class Program
    {
        static void Main()
        {

            double nrHours, hrRate, weeklyWage;

            Instructions(); //Call instructions method to show instructions.              
            GetInfo(out nrHours, out hrRate); //Call GetInfo method to get the number of worked hours and the hourly rate.
            weeklyWage = CalWage(nrHours, hrRate); //Call calwage method to calculate the weekly wage and save the result. 
            DisplayResult(ref nrHours, ref hrRate, ref weeklyWage);//Display Result.


        }
        public static void Instructions()
        {
            WriteLine("*******************************************************************");
            WriteLine("This program will calculate the user's weekly wage.");
            WriteLine();
            WriteLine("You will be asked to enter the number of hours worked in a week,");
            WriteLine("and the hourly rate of pay in dollars and cents as a single value.");
            WriteLine("*******************************************************************");
            WriteLine();
        }

        public static void GetInfo(out double nrhours, out double hrrate)
        {
            string entry; //Local Variables
            Write("Please enter the number of hours worked in a week: ");
            entry = ReadLine();
            Double.TryParse(entry, out nrhours);
            while (nrhours <= 0)
            {
                Write("Please enter the valid number of hours: ");
                entry = ReadLine();
                Double.TryParse(entry, out nrhours);
            }
            Write("Please enter the hourly rate of pay: ");
            entry = ReadLine();
            Double.TryParse(entry, out hrrate);
            while (hrrate <= 0)
            {
                Write("Please enter the valid hourly rate: ");
                entry = ReadLine();
                Double.TryParse(entry, out hrrate);
            }
        }

        public static double CalWage(double nrhours, double hrrate)
        {
            double wwage;
            wwage = nrhours * hrrate;
            return wwage;
        }
        public static void DisplayResult(ref double nrhours, ref double hrrate, ref double weeklywage)
        {
            WriteLine();
            WriteLine("The number of hours worked is {0}.", nrhours.ToString("F2"));
            WriteLine("The hourly rate is {0}.", hrrate.ToString("C"));
            WriteLine("The weekly wage is {0}.", weeklywage.ToString("C"));
        }
    }//End of Class
}//End of Namespace