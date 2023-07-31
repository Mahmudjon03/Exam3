
using ACylinder;
using AppCircle;
var cicle =new Circle(5.5,"red");
System.Console.WriteLine("radius");
System.Console.WriteLine(cicle.GetRadius());
cicle.SetRadius(3.5);

System.Console.WriteLine(cicle.toString());
System.Console.Write("Area-");
System.Console.WriteLine(cicle.Area());
System.Console.WriteLine("//--------------------------------------------------------------------//");
var cylinder= new Cylinder(12.3,4.5,"blue");
System.Console.Write("Height -> ");
System.Console.WriteLine(cylinder.GetHeight());
cylinder.SetHeight(10.5);
System.Console.WriteLine(cylinder.ToString());
System.Console.Write("Volume->");
System.Console.WriteLine(cylinder.GetVolume());

