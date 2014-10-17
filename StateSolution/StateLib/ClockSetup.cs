using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    public class ClockSetup
    {
        private IClock _YearState;
        private IClock _MonthState;
        private IClock _DayState;

        private IClock currentState;

        public ClockSetup()
        {
           _YearState = new YearState(this);
           _MonthState = new MonthState(this);
           _DayState = new DayState(this);
        }

        public IClock YearState
        {
            set { _YearState = value; }
        }
        public IClock MonthState
        {
            set { _MonthState = value; }
        }
        public IClock DayState
        {
            set { _DayState = value; }
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

        public virtual DateTime GetSelectedDate
        {
           get
            {
                return new DateTime(_YearState.SelectValue,_MonthState.SelectValue,_DayState.SelectValue);
            }
        }
        public virtual IClock YearSetupState
        {
            get
            {
                return _YearState;
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
