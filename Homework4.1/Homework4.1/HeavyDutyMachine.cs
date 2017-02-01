using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    class HeavyDutyMachine : Machine
    {
        int numM;

        public HeavyDutyMachine(int numM)
        {
            this.numM = numM;
        }

        public override string TurnOn(){
            string turning = "Turning a HeavyDutyMachine";
            numMachine = numM;
            scheduleType = "Once every four weeks";
            return turning;
        }
    }
}
