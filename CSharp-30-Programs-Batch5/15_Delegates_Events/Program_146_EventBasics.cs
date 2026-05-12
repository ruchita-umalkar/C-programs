// ============================================
// Program #146 — EventBasics
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Create and raise a basic event
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_146_EventBasics
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            alarm.Ring += () => Console.WriteLine("Alarm received by subscriber.");
            alarm.Trigger();
        }


        class Alarm
        {
            public event Action? Ring;

            public void Trigger()
            {
                Console.WriteLine("Alarm triggered.");
                Ring?.Invoke();
            }
        }
    }
}
