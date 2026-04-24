//  Program to demonstrate multiple inheritance using interface 
using System;
interface IAnimal
{
    void MakeSound();
}
interface ICanFly
{
    void Fly();
}
class Bird : IAnimal, ICanFly
{
    public void MakeSound()
    {
        Console.WriteLine("The bird chirps.");
    }

    public void Fly()
    {
        Console.WriteLine("The bird flies.");
    }
}