// See https://aka.ms/new-console-template for more information
using LAB2;
Console.WriteLine("Hello, World!");


Console.WriteLine(  "Circle : \n");
    Circle circle = new Circle();
    circle.radius = 4;
    Console.WriteLine( circle.calculate_perimeter());
    Console.WriteLine( circle.calculate_area());

Console.WriteLine("Square : \n");
    Square square = new Square { length = 4 };
    Console.WriteLine(square.calculate_perimeter());
    Console.WriteLine(square.calculate_area());

