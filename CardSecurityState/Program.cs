using System;
using CardSecurityState.Context;
using CardSecurityState.States;

namespace CardSecurityState
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating Scanner and Adding Initial state of Locked
            CardSecurityTerminal cardScanner = new CardSecurityTerminal(new LockedState());

            // Current State
            Console.WriteLine(cardScanner.CurrentState());

            // Card is Accepted
            Console.WriteLine("--- Valid Card ---");
            cardScanner.CardValid();
            Console.WriteLine(cardScanner.CurrentState());

            // Closing Door
            Console.WriteLine("--- Door Closes ---");
            cardScanner.DoorClosed();
            Console.WriteLine(cardScanner.CurrentState());

            Console.WriteLine("--- Invalid Card ---");
            cardScanner.CardInvalid();
            Console.WriteLine(cardScanner.CurrentState());
        }
    }
}
