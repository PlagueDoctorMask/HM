void MatrixInput (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            matrix[i,j] = new Random().Next(0,10);
        }
    }
}

void MatrixPrinter(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Choose task number");
string task = Console.ReadLine()!;
if(task == "47")
{
    Console.WriteLine("Choose the size");
    int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    double [,] matrix = new double[array[0],array[1]];
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * (10+10) - 10, 2);
        }
    }
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
if(task == "50")
{
    Console.WriteLine("Choose the size");
    int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[array[0],array[1]];
    MatrixInput(matrix);
    Console.WriteLine("Choose the element");
    int[] element = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    if(array [0] <= element[0] || array[1] <= element[1]) Console.WriteLine("Out of range, try again but wiser");
    else
    {
        MatrixPrinter(matrix);
        Console.WriteLine();
        Console.WriteLine(matrix[element[0], element[1]]);
    }
}
if(task == "52")
{
    Console.WriteLine("Choose the size");
    int[] array = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[array[0],array[1]];
    MatrixInput(matrix);
    Console.WriteLine("Choose the column");
    int column = int.Parse(Console.ReadLine()!);
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i,column];
    }
    MatrixPrinter(matrix);
    Console.WriteLine();
    Console.WriteLine(Math.Round((double)sum/array[0],2));
}