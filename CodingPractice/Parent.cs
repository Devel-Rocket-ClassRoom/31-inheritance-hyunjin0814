using System;

class Parent
{
    public int Value = 10;

    public void Show()
    {
        Console.WriteLine("Parent.Show()");
    }

    public void Greet()
    {
        Console.WriteLine("안녕하세요!");
    }
}

class Child : Parent
{
    public new int Value = 20;

    public new void Show()
    {
        Console.WriteLine("Child.Show()");
    }

    public void Study()
    {
        Console.WriteLine("공부합니다.");
    }
}