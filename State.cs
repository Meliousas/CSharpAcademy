using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    interface State
    {
        void insertCard();
        void insertPin(Card card);
        void withdraw();
    }
}
