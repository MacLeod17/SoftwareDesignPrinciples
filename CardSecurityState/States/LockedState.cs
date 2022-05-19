using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardSecurityState.Interfaces;

namespace CardSecurityState.States
{
    public class LockedState : ICardSecurityState
    {
        public ICardSecurityState CardInvalid()
        {
            return new LockedState();
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
            return "Locked State";
        }

        public ICardSecurityState Idle()
        {
            return new LockedState();
        }
    }
}
