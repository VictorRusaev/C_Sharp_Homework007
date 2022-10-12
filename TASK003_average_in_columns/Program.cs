Console.Clear();

int[,] matrix = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
CalcAverageInColumns(matrix);

void CalcAverageInColumns(int[,] matr, double sum = 0, int counter = 0)
{
    double[] averageArray = new double[matr.GetLength(1)];

    while(counter < matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, counter];
        }
        averageArray[counter] = Math.Round(sum / matr.GetLength(0), 2);
        Console.Write($"{averageArray[counter]}; ");
        counter++;
        sum = 0;
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
