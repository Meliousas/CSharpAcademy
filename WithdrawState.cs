using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class WithdrawState : State
    {
        Machine machine;

        public WithdrawState(Machine machine)
        {
            this.machine = machine;
        }


        public void insertCard()
        {
            Console.WriteLine("Your card is already in.");
        }


        public void insertPin(Card card)
        {
            Console.WriteLine("PIN has already been veryfied");
        }


        public void withdraw()
        {
            Console.WriteLine("Insert amount of money you want to withdraw");
            int amount;
            string writtenAmount = Console.ReadLine();
            amount = int.Parse(writtenAmount);

            if (machine.getBalance() - amount >= 0)
            {
                machine.giveCash(amount);
                machine.ejectCard();
                machine.setState(machine.getNoCardState());
            }
            else if (machine.getBalance() - amount < 0 && machine.getBalance() != 0)
            {
                Console.WriteLine("Available cash in ATM is only: " + machine.getBalance() + ". Do you want to withdraw? yes/no.");
                String writtenAnswer = Console.ReadLine();

                if (writtenAnswer.Equals("yes"))
                {
                    amount = machine.getBalance();
                    machine.giveCash(amount);
                    machine.ejectCard();
                    machine.setState(machine.getNoCashState());
                }
                else if (writtenAnswer.Equals("no"))
                {
                    Console.WriteLine("Please come later.");
                    machine.ejectCard();
                    machine.setState(machine.getNoCardState());
                }
                else { Console.WriteLine("Answer yes or no."); }
            }
        }
    }
}
