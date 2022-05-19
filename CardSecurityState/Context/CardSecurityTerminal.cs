using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardSecurityState.Interfaces;
using CardSecurityState.States;

namespace CardSecurityState.Context
{
    public class CardSecurityTerminal
    {
        ICardSecurityState securityState;

        public CardSecurityTerminal(ICardSecurityState initialState)
        {
            securityState = initialState;
        }

        public string CurrentState()
        {
            return $"Current State: {securityState.GetName()}";
        }

        public void DoorClosed()
        {
            securityState = securityState.DoorClosed();
        }

        public void CardInvalid()
        {
            securityState = securityState.CardInvalid();
        }

        public void CardValid()
        {
            securityState = securityState.CardValid();
        }

        public void IsIdle()
        {
            securityState = securityState.Idle();
        }
    }
}
