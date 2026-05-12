// ============================================
// Program #149 — EventUnsubscription
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Subscribe and unsubscribe from an event
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_149_EventUnsubscription
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            EventHandler clickHandler = (s, e) => Console.WriteLine("Button clicked!");

            button.Click += clickHandler;
            button.RaiseClick();

            button.Click -= clickHandler;
            button.RaiseClick();
            Console.WriteLine("Handler unsubscribed; second click has no handler output.");
        }


        class Button
        {
            public event EventHandler? Click;

            public void RaiseClick()
            {
                Click?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
