// Задача 50: Напишите программу, которая на вход
//принимает позицию элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.
int m =3, n =4;
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

Console.WriteLine("Введите номер элемента: ");
int N = int.Parse(Console.ReadLine());
int count = 1;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (count == N) 
        {
            N = mass[i, j];
            Console.WriteLine(mass[i, j]);
            return;
        }
        else if (count < N) 
        {
            count++;
        }
        else 
        {
            Console.WriteLine("Такого элемента нет");
        }
}
}
