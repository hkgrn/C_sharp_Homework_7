// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void RandomNumbers(double[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(-1000, 1000) / 10.0;
        }
    }
}


Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, colums];

RandomNumbers(numbers);

Console.WriteLine();
Console.WriteLine("ПОЛУЧЕННЫЙ МАССИВ: ");

for (int i = 0; i < numbers.GetLength(0); i++) {
    for (int j = 0; j < numbers.GetLength(1); j++) {
        Console.Write(numbers[i, j] + " ");
    }
    Console.WriteLine();
}
    Console.WriteLine();