using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    class Machine
    {
        public int numMachine;
        public string scheduleType;

        public Machine()
        {
            this.numMachine = 123456;
            this.scheduleType = "Once a week";
        }

        public virtual string TurnOn()
        {
            string turning = "Turning a Machine";
            return turning;
        }

        public string MachineData
        {
            get {string concat = this.numMachine + " - " + this.scheduleType;
            return concat;
            }
            
        }
    }
}
