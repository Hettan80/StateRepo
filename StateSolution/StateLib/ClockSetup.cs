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
        private IClock yearState;
        private IClock monthState;
        private IClock dayState;
        private IClock finishedState;

        private IClock currentState;

        public ClockSetup()
        {
            yearState = new YearState(this);
            monthState = new MonthState(this);
            dayState = new DayState(this);
            finishedState = new FinishedState(this);

        }

        public virtual IClock State
        {
            set { currentState = value; }
        }
        public IClock YearState
        {
            set
            {
                yearState = value;
            }
        }
        public IClock MonthState
        {
            set { monthState = value; }
        }
        public IClock DayState
        {
            set { dayState = value; }
        }

        public virtual void PushKnob()
        {
            if (currentState != null)
            {
                currentState.SelectedValue();
            }
            else
            {
                State = yearState;
            }
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
                return new DateTime(yearState.SelectValue,monthState.SelectValue,dayState.SelectValue);
            }
        }
        public virtual IClock YearSetupState
        {
            get
            {
                return yearState;
            }
        }
        public virtual IClock MonthSetupState
        {
            get
            {
                return monthState;
            }
        }
        public virtual IClock DaySetupState
        {
            get
            {
                return dayState;
            }
        }

        public virtual IClock FinishedState
        {
            get { return finishedState; }
        }
 
    }
}
