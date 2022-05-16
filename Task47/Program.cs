// Задача 47: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
int m =3, n =4;
double[,]mass = new double [m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10) + new Random().NextDouble();
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(Math.Round(mass[i, j],1) + " ");
    }
Console.WriteLine();
}