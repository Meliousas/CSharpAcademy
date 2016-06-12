using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ATMMachine
{
    class Card : AbstractCard
    {
        public int cardPin;

      
        public Card(int cardPin){
            this.cardPin=cardPin;
            }

        
        public void aboutMe(){
            Console.WriteLine("Bank: " + bankName);
            Console.WriteLine("Card type: " + CardType.Classic);
        }



    }
}
