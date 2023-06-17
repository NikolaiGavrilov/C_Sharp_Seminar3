//Задача 23
//Напишите программу, которая принимает
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void CubedPrinter (int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b.");
}

void CubedPrinterNegative (int numberN)
{
    int current = 1;
    while (current >= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current--;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Write your number: ");
int yourNum = Convert.ToInt32(Console.ReadLine());

if (yourNum > 0)
    CubedPrinter(yourNum);
else
    CubedPrinterNegative(yourNum);