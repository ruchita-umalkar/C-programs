// Microservices Communication (Basic) 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Microservices Communication Example");
        // Simulating communication between two microservices
        ServiceA serviceA = new ServiceA();
        ServiceB serviceB = new ServiceB();

        string messageFromA = serviceA.SendMessage();
        Console.WriteLine("Service A sends: " + messageFromA);

        string responseFromB = serviceB.ReceiveMessage(messageFromA);
        Console.WriteLine("Service B responds: " + responseFromB);
    }
}
