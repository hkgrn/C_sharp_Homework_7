// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void RandomArray(int[,] array) {  
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1, 99);
        }
    }
}

int x = new Random().Next(1, 10);
int y = new Random().Next(1, 10);

Console.WriteLine("СТАРТ ПРОГРАММЫ...");
Console.WriteLine();
int[,] numbers = new int[x,y];

RandomArray(numbers);

Console.WriteLine("ПОЛУЧЕН МАССИВ: ");
for (int i = 0; i < numbers.GetLength(0); i++) {
    for (int j = 0; j < numbers.GetLength(1); j++) {
        Console.Write(numbers[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("СРЕДНИЕ АРИФМЕТИЧЕСКИЕ ПО СТОЛБЦАМ:");
for (int j = 0; j < y; j++) {
double sum = 0;
    for (int i = 0; i < x; i++) {
    sum += numbers[i, j];
    }
    Console.Write($"{ Math.Round(sum/x,2) } ");
}
Console.ReadLine();