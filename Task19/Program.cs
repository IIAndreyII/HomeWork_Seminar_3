//Задача 19
//Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

// int x = new Random().Next(-100000, 100000);
// Console.WriteLine(x);

if (x < 0)
{
    x = x * -1;
}

if (x >= 100000 || x < 10000)
{
    Console.WriteLine("Ошибка.");
}

else if (x / 10000 == x % 10  &&  x % 10000 / 1000 == x / 10 % 10)
{
    Console.WriteLine("Число -  Является палиндромом.");
}

else
{
    Console.WriteLine("Число -  Не является палиндромом.");
}

