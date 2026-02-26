using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 사각형 1 ===");
Rectangle rect1 = new Rectangle();
rect1.Width = 10;
rect1.Height = 5;
Console.WriteLine($"가로: {rect1.Width}, 세로: {rect1.Height}");
Console.WriteLine($"넓이: {rect1.AreaCalculate()}");
Console.WriteLine($"둘레: {rect1.PerimeterCalculate()}");
Console.WriteLine($"정사각형 여부: {rect1.IsSquareCalculate()}\n");

Console.WriteLine("=== 사각형 2 ===");
Rectangle rect2 = new Rectangle();
rect2.Width = 7;
rect2.Height = 7;
Console.WriteLine($"가로: {rect2.Width}, 세로: {rect2.Height}");
Console.WriteLine($"넓이: {rect2.AreaCalculate()}");
Console.WriteLine($"둘레: {rect2.PerimeterCalculate()}");
Console.WriteLine($"정사각형 여부: {rect2.IsSquareCalculate()}\n");

Console.WriteLine("=== 기본 사각형 ===");
Rectangle rect = new Rectangle();
Console.WriteLine($"가로: {rect.Width}, 세로: {rect.Height}");
Console.WriteLine($"넓이: {rect.AreaCalculate()}");
Console.WriteLine($"둘레: {rect.PerimeterCalculate()}");
Console.WriteLine($"정사각형 여부: {rect.IsSquareCalculate()}\n");


class Rectangle
{
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;
    public int Area { get; private set; }
    public int Perimeter { get; private set; }
    public bool IsSquare { get; private set; }

    public int AreaCalculate()
    {
        Area = Width * Height;
        return Area;
    }

    public int PerimeterCalculate()
    {
        Perimeter = 2 * (Width + Height);
        return Perimeter;
    }
    public bool IsSquareCalculate()
    {
        IsSquare = Width == Height;
        return IsSquare;
    }
}
