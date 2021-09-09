using System;

namespace WhenWereYouBorn
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisestage oma sünniaasta:");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            string v = $"Sa oled {Age} aastat vana.";
            string value = v;
            Console.WriteLine(value);



        }
    }
}
