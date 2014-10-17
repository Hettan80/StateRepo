using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StateLib
{
    public interface IClock
    {
       void PreviousValue();
        void NextValue();
        void SelectClockValue();
        int SelectValue { get;}
    }
}
