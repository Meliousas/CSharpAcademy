using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Machine
    {

        State noCardState;
        State cardInState;
        State withdrawState;
        State noCashState;

        State state = noCashState;
        public int balance = 0;

        public Machine(int currentBalance)
        {
            noCardState = new NoCardState(this);
            cardInState = new CardInState(this);
            withdrawState = new WithdrawState(this);
            noCashState = new NoCashState(this);

            this.balance = currentBalance;
            if (currentBalance > 0)
            {
                state = noCardState;
            }

        }

        public void insertCard()
        {
            state.insertCard();
        }

        public void insertPin(Card card)
        {
            state.insertPin(card);
        }

        public void withdraw()
        {
            state.withdraw();
        }

        public void giveCash(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("You received your money.");
        }

        public void ejectCard()
        {
            Console.WriteLine("Card has been ejected");
        }

        public void blockCard(Card card) { Console.WriteLine("Card has been blocked"); }

        public void returnBalance() { Console.WriteLine("ATM balance:" + balance); }  // pomocniczo żeby sprawdzić saldo bankomatu




        //////////////////////////////////////////////////////////////////////


       

        public State getNoCardState()
        {
            return noCardState;
        }



        public int getBalance()
        {
            return balance;
        }



        public State getCardInState()
        {
            return cardInState;
        }



        public State getWithdrawState()
        {
            return withdrawState;
        }



        public State getNoCashState()
        {
            return noCashState;
        }


        public void setState(State state)
        {
            this.state = state;
        }

    }
}
