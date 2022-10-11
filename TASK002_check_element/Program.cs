Console.Clear();

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
FindElement(matrix);

void FindElement(int[,] matr)
{
    Console.Write("Введите строку: ");
    int row = int.Parse(Console.ReadLine()!);

    Console.Write("Введите столбец: ");
    int column = int.Parse(Console.ReadLine()!);

    if(row < matr.GetLength(0) && column < matr.GetLength(1))
    {
        Console.WriteLine(matr[row, column]);
    }
    else
    {
        Console.WriteLine("Нет такого элемента");
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matr)
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
