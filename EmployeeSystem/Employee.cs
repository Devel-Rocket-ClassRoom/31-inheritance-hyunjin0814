using System;

class Employee
{
    protected string _name;
    protected int _baseSalary;

    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetBaseSalary()
    {
        return _baseSalary; 
    }

    public int CalculatePay()
    {
        return _baseSalary; 
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[직원] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:#,###}원");
        Console.WriteLine($"총 급여: {CalculatePay():#,###}원");
    }
}
