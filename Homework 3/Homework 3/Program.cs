using Microsoft.VisualBasic;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            var today = DateTime.Today;
            DateTime birthdate = new DateTime(2004, 2, 17);
            var age=today.Year-birthdate.Year;
            Console.WriteLine("Yash:"+age);          
        }
    }
}