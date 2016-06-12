using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class NoCardState : State
    {
        Machine machine;

        public NoCardState(Machine machine) { this.machine = machine; }

        public void insertCard()
        {
            Console.WriteLine("Card in.");
            machine.setState(machine.getCardInState());
        }


        public void insertPin(Card card)
        {
            Console.WriteLine("Insert your card first.");
        }
        public void withdraw()
        {
            Console.WriteLine("Not available.");
        }
    }
}
