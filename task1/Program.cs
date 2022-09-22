// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Программа для проверки, является ли число палиндромом.");

// вводим данные

Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());
int len = (int)Math.Floor(Math.Log10(number)); // добавил округление, так как с цифры 3 округляет в большую сторону
int i = 1;
int count = 0;

// создаём условие для проверки первого и последнего числа, с каждой итерации смещаемся к центру на одну цифру

if (number >= 10) // число меньше 10 не может быть палиндромом
{
    while (len > 0)
    {
        int div1 = Convert.ToInt32(Math.Pow(10, (len)));
        int rem1 = Convert.ToInt32(Math.Pow(10, (len + 1)));
        int firstnum = (number % rem1) / div1;

        int div2 = Convert.ToInt32(Math.Pow(10, (i - 1)));
        int rem2 = Convert.ToInt32(Math.Pow(10, (i)));
        int lastnum = (number % rem2) / div2;

        if (firstnum == lastnum)
        {
            count++;
        }    
        len--;
        i++;
    }
    if (count == i - 1)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом.");
    }
}
if (number < 10)
{
    Console.WriteLine($"Число {number} не является палиндромом.");
}
