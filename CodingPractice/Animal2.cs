using System;

class Animal2
{
    public Animal2()
    {
        Console.WriteLine("Animal 기본 생성자");
    }
}

class Dog2 : Animal2
{
    public Dog2()
    {
        Console.WriteLine("Dog 생성자");
    }
}