using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write First Time hours and minutes");

            int FirstHours = Convert.ToInt32(Console.ReadLine());
            int FirstMinutes = Convert.ToInt32(Console.ReadLine());
            var FirstTime = new Time(FirstHours, FirstMinutes);

            Console.WriteLine($"First Time is {FirstHours} : {FirstMinutes}");

            Console.WriteLine("Write Second Time hours and minutes");
            int SecondHours = Convert.ToInt32(Console.ReadLine());
            int SecondMinutes = Convert.ToInt32(Console.ReadLine());
            var SecondTime = new Time(SecondHours, SecondMinutes);

            Console.WriteLine($"Second Time is {SecondHours} : {SecondMinutes}");

            Console.WriteLine("Choose Operation:\n" +
                "1: +\n " +
                "2: -\n " +
                "3: Implicite From Int to Time \n"+
                "4: Explicite Time to int\n ");

            int operate = Convert.ToInt32(Console.ReadLine());

            switch(operate)
            {
                case 1:
                    Time ResultOfAdding = FirstTime + SecondTime;
                    
                    Console.WriteLine($"New Time is: {ResultOfAdding.ToString()}");
                    break;

                case 2:
                    Time ResultOfSubtracting = FirstTime - SecondTime;
                    Console.WriteLine($"New Time is: {ResultOfSubtracting.ToString()}");
                    break;

                case 3:
                   Time ThirdTime = (Time)SecondTime;
                    Console.WriteLine($"{ThirdTime}");
                    break;

                case 4:
                    int Hours = (int)FirstTime;
                    Console.WriteLine($"{Hours}");
                    break;

            }

        }
    }
}
