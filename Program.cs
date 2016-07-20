using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Program
    {
        static void Main(string[] args)
         {
            Machine machine = new Machine(10000);
            Card card = new Card(1111);

            machine.insertCard();
            machine.insertPin(card);
            machine.withdraw();
            
            Console.ReadLine();
        }
    }
}
