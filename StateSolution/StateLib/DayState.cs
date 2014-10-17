using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateLib
{
    public class DayState : IClock
    {
        private ClockSetup clockSetup;
        private int day;

        public DayState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            day = DateTime.Now.Day;
        }
        public virtual void NextValue()
        {
            if (day < DateTime.DaysInMonth(new DateTime().Year,
               new DateTime().Month))
            {
                day++;
            }
        }

        public virtual void SelectClockValue()
        {
            Console.WriteLine("Today day is" + day);
            //clockSetup
        }

        public virtual void PreviousValue()
        {
            if (day > 1)
            {
                day--;
            }

        }

        public int SelectValue
        {
            get { return day; }
        }
    }
}
