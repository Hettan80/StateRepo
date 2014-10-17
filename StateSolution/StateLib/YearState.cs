using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    public class YearState : IClock
    {
        private ClockSetup clockSetup;
        private int year;

        public YearState(ClockSetup clockSetup, int y)
        {
            this.clockSetup = clockSetup;
            year =  y;
        }


        public YearState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
            year = DateTime.Now.Year;
        }

        public virtual void NextValue()
        {
            year++;
        }
        public virtual void SelectedValue()
        {
        Console.WriteLine("Year is" + year);
            clockSetup.State = clockSetup.MonthSetupState;
        }

        public virtual void PreviousValue()
        {
            year--;
        }

       public int SelectValue
        {
            get { return year; }
        }
    }

}
