using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    abstract class AbstractCard
    {
       public string bankName = "Money For Nothing";

        public enum CardType
        {
            Classic,
            Silver,
            Gold
        };

    }
}
