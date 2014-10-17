using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    interface IClock
    {
         YearState YearState { get; set; }
         MonthState MonthState { get; set; }
         DayState DayState { get; set; }
    }
}
