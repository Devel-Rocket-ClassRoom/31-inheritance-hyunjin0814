using System;

class Developer : Employee
{
    private int _overtimeHours;

    public Developer(string name, int baseSalary, int overtimeHours) : base(name, baseSalary)
    {
        _overtimeHours = overtimeHours;
    }

    public new int CalculatePay()
    {
        return _baseSalary + _overtimeHours * 20000;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:#,###}원");
        Console.WriteLine($"초과근무: {_overtimeHours}시간");
        Console.WriteLine($"총 급여: {CalculatePay():#,###}원");
    }
}