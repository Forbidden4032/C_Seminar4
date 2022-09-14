//Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран. Элементы массива вводятся пользователем.

int[] array = new int[8];

for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите числовой элемент №{i+1} и нажмите Enter: ");
        array[i] = int.Parse(Console.ReadLine());
    }

Console.WriteLine("Ввод элементов закончен, вывод на экран результата: ");
    
for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }



