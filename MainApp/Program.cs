System.Console.WriteLine();
Console.WriteLine("CIRCLE");
var circle = new Circle(3.1, "green", true);
circle.SetRadius(5);
Console.WriteLine(circle.GetArea());
Console.WriteLine(circle.GetPerimeter());
System.Console.WriteLine(circle.ToString());
System.Console.WriteLine();

var rectangle = new Rectangle(3, 4, "red", false);
rectangle.SetWidth(3);
rectangle.SetLength(4);
Console.WriteLine(rectangle.GetArea());
Console.WriteLine(rectangle.GetPerimeter());
System.Console.WriteLine(rectangle.ToString());
System.Console.WriteLine();