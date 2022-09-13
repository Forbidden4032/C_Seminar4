// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B. Решить задачу с использованием методов.
int Pow(int x, int count)
{   
    int sum = 1;
    while(count > 0)
        {
            sum = sum*x;
            count--;   
        }
    return sum;
}

Console.WriteLine("Enter first int: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second int: ");
int y = int.Parse(Console.ReadLine());

int newpow = Pow(x, y);
Console.WriteLine(newpow);