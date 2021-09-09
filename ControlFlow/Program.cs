using System;
using System.Diagnostics;

namespace ControlFlow
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    class Program
    {
        private static object GetDebuggerDisplay()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma vanus:");
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana.");
            }

            if (Age >= 18)
            {
                return;
            }
            NewMethod();
        }

        
       {
        private static void NewMethod() => Console.WriteLine("Oled liiga noor.");
        }

