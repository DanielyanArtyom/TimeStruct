using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeStruct
{
    public struct Time
    {
        public int TimeOfDay { get; set; }
        public int NumberOfMinutes { get; set; }
        public int NumberOfHours { get; set; }

        public static Time Noon
        {
            get
            {
                return new Time(12, 0);
            }
        }

        public Time(int hours, int minutes)
        {
            if (hours > 23 || hours < 0)
            {
                throw new Exception("Wrong hours Format");
            }

            NumberOfHours = hours;

            if (minutes > 59 || minutes < 0)
            {
                throw new Exception("Wrong minutes format");
            }

            
            NumberOfMinutes = minutes;
            TimeOfDay = (60 * hours) + minutes;
        }

        

        public static Time operator +(Time FirstTime, Time SecondTime)
        {
            
            var ReturnResult = new Time() // getting 3rd Time Type 
            {
                NumberOfHours = FirstTime.NumberOfHours + SecondTime.NumberOfHours,
                NumberOfMinutes = FirstTime.NumberOfMinutes + SecondTime.NumberOfMinutes,
                TimeOfDay = FirstTime.TimeOfDay + SecondTime.TimeOfDay
            };

            if (ReturnResult.NumberOfMinutes >= 60)
            {
                ++ReturnResult.NumberOfHours;
                ReturnResult.NumberOfHours -= 60;
            }

            return ReturnResult;

        }

        public static Time operator -(Time FirstTime, Time SecondTime)
        {
            var ReturnResult = new Time() // getting 3rd Time Type 
            {
                NumberOfHours = Math.Abs(FirstTime.NumberOfHours - SecondTime.NumberOfHours),
                NumberOfMinutes =Math.Abs( FirstTime.NumberOfMinutes - SecondTime.NumberOfMinutes),

                TimeOfDay = FirstTime.TimeOfDay - SecondTime.TimeOfDay
            };

            if (ReturnResult.NumberOfMinutes >= 60)
            {
                ++ReturnResult.NumberOfHours;
                ReturnResult.NumberOfHours -= 60;
            }

            return ReturnResult;

        }

        public static implicit operator Time(int minutes)
        {
            var ResultOfHours = minutes / 60;
            var ResultOfMinutes = minutes % 60;

            return new Time(ResultOfHours, ResultOfMinutes);

        }

        public static explicit operator int(Time time)
        {
            return (time.NumberOfHours * 60) + time.NumberOfMinutes;
        }





        public override string ToString()
        {
            return $"{NumberOfHours.ToString()} : {NumberOfMinutes.ToString()}";
        }


    }
}
