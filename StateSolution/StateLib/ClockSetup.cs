using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    public class ClockSetup
    {
        public IClock YearState;
        public IClock MonthState;
        public IClock DayState;
        public IClock currentState;

        public ClockSetup()
        {
            YearState = new YearState(this);
            //MonthState = new MontState(this);
            //DayState = new DayState(this);
        }



        public virtual void PushKnob()
        {
            currentState.SelectedValue();
        }

        public virtual void RotateRight()
        {
            currentState.NextValue();
        }

        public virtual void RotateLeft()
        {
            currentState.PreviousValue();
        }

        public DateTime GetSelectedDate()
        {
         
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
