// ============================================
// Program #150 — WeakEventPattern
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Demonstrate a weak event pattern to avoid memory leaks
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_150_WeakEventPattern
    {
        static void Main(string[] args)
        {
            WeakEventSource source = new WeakEventSource();
            Listener listener = new Listener("Listener-1");

            source.Subscribe(listener, l => l.Handle);
            source.Raise("First event");

            listener = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            source.Raise("Second event after GC");
        }


        class WeakEventSource
        {
            private readonly System.Collections.Generic.List<WeakReference<Action<string>>> _handlers =
                new System.Collections.Generic.List<WeakReference<Action<string>>>();

            public void Subscribe<T>(T target, Func<T, Action<string>> handlerSelector) where T : class
            {
                Action<string> handler = handlerSelector(target);
                _handlers.Add(new WeakReference<Action<string>>(handler));
            }

            public void Raise(string message)
            {
                Console.WriteLine($"Source raised: {message}");
                for (int i = _handlers.Count - 1; i >= 0; i--)
                {
                    if (_handlers[i].TryGetTarget(out Action<string>? handler))
                    {
                        handler(message);
                    }
                    else
                    {
                        _handlers.RemoveAt(i);
                    }
                }
                Console.WriteLine($"Active weak handlers: {_handlers.Count}");
            }
        }

        class Listener
        {
            private readonly string _id;

            public Listener(string id)
            {
                _id = id;
            }

            public void Handle(string message)
            {
                Console.WriteLine($"{_id} received: {message}");
            }

            ~Listener()
            {
                Console.WriteLine($"{_id} finalized.");
            }
        }
    }
}
