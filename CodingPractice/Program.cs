using System;

// README.md를 읽고 코드를 작성하세요.
Child child = new Child();
child.Greet();
child.Study();

Dog dog = new Dog();
dog.Name = "초코";
dog.Eat();
dog.Bark();

Cat cat = new Cat();
cat.Name = "나비";
cat.Eat();
cat.Meow();

Product product = new Product();
Console.WriteLine(product.ToString());
Console.WriteLine(product.GetType());

Child2 child2 = new Child2();
child2.ShowValues();
Console.WriteLine(child2.PublicValue);

Manager manager = new Manager();
manager.ShowInfo();

Student student = new Student("홍길동", 3);
Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");

Dog2 dog2 = new Dog2();

Dog dog_1 = new Dog { Name = "멍멍이" };
Animal animal = dog_1;
animal.Eat();

Dog dog_2 = (Dog)animal;
dog_2.Bark();

if (animal is Dog)
{
    Dog dog_3 = (Dog)animal;
    dog_3.Bark();
}

animal = new Cat { Name = "야옹이" };

Dog dog_4 = animal as Dog;
if (dog_4 != null)
{
    dog_4.Bark(); 
}
else
{
    Console.WriteLine("Dog 타입이 아닙니다.");
}

Asset[] assets = new Asset[3];
assets[0] = new Stock { Name = "삼성전자", Shares = 100 };
assets[1] = new House { Name = "아파트", Mortgage = 300000000 };
assets[2] = new Stock { Name = "SK하이닉스", Shares = 50 };

foreach (Asset asset in assets)
{
    Console.WriteLine(asset.Name);
}

Rectangle rect = new Rectangle { Name = "사각형", Width = 10, Height = 5 };
Circle circle = new Circle { Name = "원", Radius = 3 };

Console.WriteLine($"{rect.Name} 넓이: {rect.GetArea()}");
Console.WriteLine($"{circle.Name} 넓이: {circle.GetArea():F2}");

Car car = new Car();
car.Start();
car.Stop();

FinalClass final =  new FinalClass();
final.Display();

Child child1 = new Child();
Parent parent1 = child1;
Console.WriteLine($"child.Value: {child1.Value}");
Console.WriteLine($"parent.Value: {parent1.Value}");
child1.Show();
parent1.Show();

Console.WriteLine(dog is Animal);
Console.WriteLine(dog is Dog);
Console.WriteLine(dog is Cat);

GameCharacter[] characters = new GameCharacter[]
{
    new Warrior("아서", 25),
    new Mage("멀린", 40),
    new Warrior("란슬롯", 30)
};

foreach (GameCharacter character in characters)
{
    character.ShowStatus();
    character.Attack();
    Console.WriteLine();
}