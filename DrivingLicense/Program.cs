using System;
using System.Diagnostics;

namespace DrivingLicense
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui vana sa oled?");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine("Siin on teie juhiluba.");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Sa oled liiga noor, et juhilube teha!");
            }
    }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
