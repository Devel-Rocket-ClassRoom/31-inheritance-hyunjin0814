using System;

class Intern : Employee
{
    public Intern(string name) : base(name, 1500000)
    {

    }

    public new int CalculatePay()
    {
        return 1500000;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {1500000:#,###}원");
        Console.WriteLine($"총 급여: {CalculatePay():#,###}원");
    }
}