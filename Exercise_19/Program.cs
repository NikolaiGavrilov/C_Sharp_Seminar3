// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void PalindromCheck (int num) {
int numFirstDigit = Convert.ToInt32(num / 10000);
int numLastDigit = Convert.ToInt32(num % 10);
int numSecondDigit = Convert.ToInt32(num / 1000 % 10);
int numPreLastDigit = Convert.ToInt32(num % 100 / 10);

if (numFirstDigit == numLastDigit && numSecondDigit == numPreLastDigit)
    Console.WriteLine("Введенное число является палиндромом");
else
    Console.WriteLine("Введенное число не является палиндромом");
}

Console.WriteLine("Введите пятизначное число: ");
int yourNum = Convert.ToInt32(Console.ReadLine());
PalindromCheck (yourNum);


