// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetNumber()
{
    Console.WriteLine("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Math.Abs(GetNumber());
if (number <= 99999 && number > 9999)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
        Console.WriteLine("Заданное число является палиндромом");
    else
        Console.WriteLine("Заданное число не является палиндромом");
}
else
    Console.WriteLine("Необходимо ввести пятизначное число!");