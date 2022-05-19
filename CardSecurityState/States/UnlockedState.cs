using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardSecurityState.Interfaces;

namespace CardSecurityState.States
{
    public class UnlockedState : ICardSecurityState
    {
        public ICardSecurityState CardInvalid()
        {
            return new UnlockedState();
        }

        public ICardSecurityState CardValid()
        {
            return new UnlockedState();
        }

        public ICardSecurityState DoorClosed()
        {
            return new LockedState();
        }

        public string GetName()
        {
            return "Unlocked State";
        }

        public ICardSecurityState Idle()
        {
            return new UnlockedState();
        }
    }
}
