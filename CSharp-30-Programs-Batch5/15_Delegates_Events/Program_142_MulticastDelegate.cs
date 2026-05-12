// ============================================
// Program #142 — MulticastDelegate
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Use multicast delegate to invoke multiple methods
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_142_MulticastDelegate
    {
        static void Main(string[] args)
        {
            Notifier notifier = NotifyByEmail;
            notifier += NotifyBySms;
            notifier("Meeting at 5 PM");
        }


        delegate void Notifier(string message);

        static void NotifyByEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }

        static void NotifyBySms(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
