using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class NoCashState
    {
        Machine machine;

        public NoCashState(Machine machine)
        {
            this.machine = machine;
        }


       
    public void insertCard()
        {
            Console.WriteLine("ATM is out of money. We're sorry.");
        }

        
    public void insertPin(Card card)
        {
            Console.WriteLine("ATM is out of money. We're sorry.");
        }

        
    public void withdraw()
        {
            Console.WriteLine("ATM is out of money. We're sorry.");
        }
    }
}
