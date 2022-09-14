//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: " );
int x = int.Parse(Console.ReadLine());

int summ = 0;

while(x > 0)
    {
        summ = summ + (x%10);
        x = x / 10;
    }
Console.WriteLine($"Сумма чисел введенного числа равна {summ}");







