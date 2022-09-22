// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// вводим данные

Console.Write("Введите число N - ");
int N = int.Parse(Console.ReadLine());

// используем цикл для поиска куба числа

for (int i = 1; i <= N; i++)
{
    int c = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine($"Куб числа {i} равен {c}");
}