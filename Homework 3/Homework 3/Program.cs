using Microsoft.VisualBasic;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            var today = DateTime.Today;
            DateTime birthdate = new DateTime(1990, 2, 28);
            var age=today.Year-birthdate.Year;
            Console.WriteLine("Yash:"+age);          
        }
    }
}