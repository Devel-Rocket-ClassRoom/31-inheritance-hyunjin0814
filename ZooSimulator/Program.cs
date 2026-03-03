using System;

// README.md를 읽고 코드를 작성하세요.
Animal[] animals = new Animal[]
{
    new Lion("시바", 5),
    new Elephant("덤보", 10),
    new Penguin("뽀로로", 3)
};

Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===");
Console.WriteLine();

Console.WriteLine("[동물 정보]");
foreach (var animal in animals)
{
    animal.DisplayInfo();
}
Console.WriteLine();

Console.WriteLine("[동물 소리]");
foreach (var animal in animals)
{
    animal.MakeSound();
}
Console.WriteLine();

Console.WriteLine("[동물 행동]");
Lion lion = (Lion)animals[0];
