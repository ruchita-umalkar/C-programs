// ============================================
// Program #148 — EventPublisherSubscriber
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Implement publisher-subscriber pattern with events
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_148_EventPublisherSubscriber
    {
        static void Main(string[] args)
        {
            NewsPublisher publisher = new NewsPublisher();
            Subscriber a = new Subscriber("Alice");
            Subscriber b = new Subscriber("Bob");

            publisher.NewsPublished += a.OnNewsPublished;
            publisher.NewsPublished += b.OnNewsPublished;

            publisher.Publish("C# 14 preview announced");
        }


        class NewsPublisher
        {
            public event EventHandler<string>? NewsPublished;

            public void Publish(string news)
            {
                Console.WriteLine($"Publishing: {news}");
                NewsPublished?.Invoke(this, news);
            }
        }

        class Subscriber
        {
            private readonly string _name;

            public Subscriber(string name)
            {
                _name = name;
            }

            public void OnNewsPublished(object? sender, string news)
            {
                Console.WriteLine($"{_name} received: {news}");
            }
        }
    }
}
