using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    public class ClockSetup
    {
        public YearState YearState { get; set; }
        public MonthState MonthState { get; set; }
        public DayState DayState { get; set; }

        public void PushKnob()
        { }
        public void RotateRight()
        { }
        public void RotateLeft()
        { }
        public void GetSelectedDate()
        { }

    }
}
