// ============================================
// Program #285 — HotelBookingSystem
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Hotel room booking, checkout, and availability checker.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_285_HotelBookingSystem
    {
        class Room
        {
            public int Number { get; }
            public bool IsBooked { get; private set; }
            public Room(int number) { Number = number; }
            public bool Book() { if (IsBooked) return false; IsBooked = true; return true; }
            public bool Checkout() { if (!IsBooked) return false; IsBooked = false; return true; }
        }

        static void Main(string[] args)
        {
            var rooms = new System.Collections.Generic.List<Room>();
            for (int i = 101; i <= 105; i++) rooms.Add(new Room(i));

            while (true)
            {
                Console.WriteLine("\n1.Available 2.Book 3.Checkout 4.Exit");
                Console.Write("Choose: ");
                string c = (Console.ReadLine() ?? "").Trim();
                if (c == "4") break;
                if (c == "1")
                {
                    foreach (var r in rooms) if (!r.IsBooked) Console.WriteLine($"Room {r.Number} available");
                }
                else if (c == "2" || c == "3")
                {
                    Console.Write("Room number: ");
                    if (!int.TryParse(Console.ReadLine(), out int num)) continue;
                    Room room = rooms.Find(r => r.Number == num);
                    if (room == null) { Console.WriteLine("Room not found."); continue; }
                    bool ok = c == "2" ? room.Book() : room.Checkout();
                    Console.WriteLine(ok ? "Success." : "Operation failed.");
                }
            }
            Console.WriteLine("Hotel system closed.");
        }
    }
}
