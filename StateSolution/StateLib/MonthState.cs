using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    public class MonthState : IClock
    {
        private ClockSetup clockSetup;
        private int month;
        private int _m;

        public MonthState(ClockSetup clockSetup, int m)
        {
            this.clockSetup = clockSetup;
            month = DateTime.Now.Month;
            this._m = m;

        }

        public virtual void NextValue()
        {
            if (month < 12)
            {
                month++;
            }
        }

        public virtual void SelectedValue()
        {
            Console.WriteLine("Month is" + month);
            //clockSetup
        }

        public virtual void PreviousValue()
        {
            if (month > 1)
            {
                month--;
            }

        }

        public virtual int SelectValue
        {
            get { return month; }
        }
    }
}

