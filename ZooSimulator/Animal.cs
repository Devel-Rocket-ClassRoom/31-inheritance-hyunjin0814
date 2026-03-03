using System;

abstract class Animal
{
    protected string _sound;
    public string Name { get; protected set; }
    public int Age { get; protected set; }

    protected Animal(string name, int age)
    {
        Name = name; Age = age; 
    }

    public void Eat()
    {
        Console.WriteLine($"{Name}이(가) 먹이를 먹습니다.");
    }

    public abstract void MakeSound();

    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}살");
    }
}