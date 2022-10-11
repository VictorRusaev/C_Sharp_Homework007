Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[m, n];

FillArray(matrix);
PrintArray(matrix);

void FillArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
