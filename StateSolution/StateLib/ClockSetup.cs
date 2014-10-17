using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    public class ClockSetup
    {
        private IClock YearState;
        private IClock MonthState;
        private IClock DayState;

        private IClock currentState;

        public ClockSetup()
        {
            YearState = new YearState(this);
           //MonthState = new MontState(this);
           //DayState = new DayState(this);
        }



        public virtual void PushKnob()
        {
            currentState.SelectClockValue();
        }

        public virtual void RotateRight()
        {
            currentState.NextValue();
        }

        public virtual void RotateLeft()
        {
            currentState.PreviousValue();
        }

        public virtual DateTime GetSelectedDate
        {
           get
            {
                return new DateTime(YearState.SelectValue,MonthState.SelectValue,DayState.SelectValue);
            }
        }
        public virtual IClock YearSetupState
        {
            get
            {
                return YearState;
            }
        }
        //public virtual IClock MonthSetupState
        //{
        //    get
        //    {
        //        return MonthState;
        //    }
        //}
        //public virtual IClock DaySetupState
        //{
        //    get
        //    {
        //        return DayState;
        //    }
        //}

 
    }
}
