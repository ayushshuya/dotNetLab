using MGR;
using EMP;
using Drawing;
// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Hello, World!");
// Employee e1=new Employee(" ayush","gupta",01,65000);
// Console.WriteLine(e1);

Manager m1=new Manager(" ayush","gupta",01,65000,20000,5000);
Console.WriteLine(m1);

Point startPoint1=new Point(45,56);
Point endPoint1 =new Point(300,120);

//Console.WriteLine(startPoint);

Line s1=new Line(startPoint1,endPoint1,5,"Red");
s1.Draw();

Line s2=new Line();
s2.Draw();

List<Shape> allShapes=new List<Shape>();
allShapes.Add(s1);
allShapes.Add(s2);

foreach(Shape s in allShapes)
s.Draw();