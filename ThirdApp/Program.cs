// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void GetPow(int number)
{
    Console.WriteLine("Таблица кубов от 1 до " + number + ": ");
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine(Math.Pow(count, 3));
        count++;
    }
}
GetPow(GetNumber());