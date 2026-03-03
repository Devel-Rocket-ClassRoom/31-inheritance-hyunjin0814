using System;

abstract class Vehicle
{
    public void Stop()
    {
        Console.WriteLine("정지합니다.");
    }
    public abstract void Start();
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("자동차 시동을 켭니다.");
    }
}
