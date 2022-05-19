// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int m =4, n =4;
int[,]mass = new int [m,n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
Console.WriteLine();
}

double sum = 0;
double A = 0;
for (int j = 0; j < mass.GetLength(1); j++)
{
    sum = 0;
    A = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum += mass[i, j];
    }
A = sum/ m;
Math.Round(A, 1);
Console.Write(A + " ");
}
