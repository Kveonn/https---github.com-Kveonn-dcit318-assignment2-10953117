using System;

// Inheritance and Method Overriding
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

// Abstract Classes and Methods
abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

// Interfaces
interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Inheritance and Method Overriding
        Animal animal = new Animal();
        animal.MakeSound(); // Output: Some generic sound

        Dog dog = new Dog();
        dog.MakeSound(); // Output: Bark

        Cat cat = new Cat();
        cat.MakeSound(); // Output: Meow

        // Abstract Classes and Methods
        Circle circle = new Circle(5);
        Console.WriteLine("Area of the circle: " + circle.GetArea()); // Output: Area of the circle: 78.53981633974483

        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine("Area of the rectangle: " + rectangle.GetArea()); // Output: Area of the rectangle: 24

        // Interfaces
        Car car = new Car();
        car.Move(); // Output: Car is moving

        Bicycle bicycle = new Bicycle();
        bicycle.Move(); // Output: Bicycle is moving

        Console.ReadLine();
    }
}