using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._1
{
    class LightMachine : Machine
    {
        int numM;

        public LightMachine(int numM)
        {
            this.numM = numM;
        }

        public override string TurnOn(){
            string turning = "Turning a LightMachine";
            numMachine = numM;
            scheduleType = "Once a week";
            return turning;
        }
    }
}
