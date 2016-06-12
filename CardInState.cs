using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class CardInState : State
    {
        Machine machine;

        public CardInState(Machine machine)
        {
            this.machine= machine;
        }


        public void insertCard()
        {
            Console.WriteLine("Your card is already in.");
        }


        public void insertPin(Card card)
        {
            card.aboutMe();

            int i;
            for (i = 1; i < 4; i++)
            {

                Console.WriteLine("Insert pin:");
                string written = Console.ReadLine();
                int pin = int.Parse(written);
                

                if (card.cardPin == pin)
                {
                    Console.WriteLine("Podano poprawny kod PIN.");
                    machine.setState(machine.getWithdrawState());
                    break;
                }
                if (card.cardPin != pin)
                {
                    Console.WriteLine("Kod pin jest niepoprawny!");
                    Console.WriteLine("Liczba pozostałych prób:" + (3 - i));
                }
                if (card.cardPin != pin && i == 3)
                {
                    machine.blockCard(card);
                    machine.ejectCard();
                    machine.setState(machine.getNoCardState());
                }
            }
        }


        public void withdraw()
        {
            Console.WriteLine("Insert yout pin first.");
        }


    }
}

