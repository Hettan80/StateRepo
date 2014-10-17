using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    class FinishedState:IClock
    {
        private ClockSetup clockSetup;

        public FinishedState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
        }

        public void PreviousValue()
        {
            Console.WriteLine("Ignored...");
        }

        public void NextValue()
        {
            Console.WriteLine("Ignored...");
        }

        public void SelectClockValue()
        {
            DateTime selectedDate = clockSetup.GetSelectedDate;
            Console.WriteLine("Date set to: "+selectedDate);
        }

        public int SelectValue
        {
            get { throw new System.NotSupportedException("Clock setup finished"); }
        }
    }
}
