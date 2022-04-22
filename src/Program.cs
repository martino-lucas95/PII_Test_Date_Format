using System;

namespace DateFormat
{
    public class Program
    {
        public static String ChangeFormat(String year)
        {
            return year.Substring(0,2) + "-" + year.Substring(3, 2) + "-" + year.Substring(6);
        }

        public static String ReverseDate(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0,2);
        }


        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine($"{testDate} se convierte a: {ChangeFormat(testDate)} ");
            Console.WriteLine($"{testDate} se convierte a: {ReverseDate(testDate)} ");
        }
    }
}