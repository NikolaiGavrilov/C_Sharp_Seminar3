//Задача 21
//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние 
//между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double DistAB (int xA, int xB, int yA, int yB, int zA, int zB)
{
    double dist = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA));
    return dist;
}

Console.WriteLine("Input the X-axis coordinate of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the Y-axis coordinate of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the Z-axis coordinate of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the X-axis coordinate of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the Y-axis coordinate of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the Z-axis coordinate of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"The distance between A({xCoordA},{yCoordA},{zCoordA}) and B({xCoordB},{yCoordB},{zCoordB}) in 3-dimensional space is {distanceAB:f2}.");
