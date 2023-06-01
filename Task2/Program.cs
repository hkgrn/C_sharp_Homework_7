// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void RandomArray(int[,] array) {  
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = new Random().Next(1, 99);
        }
    }
}

int x = new Random().Next(1, 10);
int y = new Random().Next(1, 10);

Console.Write("Введите номер строки целевого элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца целевого элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[x,y];

RandomArray(numbers);

Console.WriteLine("ПОЛУЧЕННЫЙ МАССИВ: ");
for (int i = 0; i < numbers.GetLength(0); i++) {
    for (int j = 0; j < numbers.GetLength(1); j++) {
        Console.Write(numbers[i, j] + " ");
    }
    Console.WriteLine();
}
    Console.WriteLine();

if ((row < numbers.GetLength(0)) && (column < numbers.GetLength(1))) { 
    Console.WriteLine(numbers[row, column]);
}
else {
    Console.WriteLine("Такой позиции в массиве нет.");
}
