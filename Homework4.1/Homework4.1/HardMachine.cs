using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    class HardMachine : Machine
    {
        int numM;

        public HardMachine(int numM)
        {
            this.numM = numM;
        }

        public override string TurnOn(){
            string turning = "Turning a HardMachine";
            numMachine = numM;
            scheduleType = "Once every two weeks";
            return turning;
        }
    }
}
