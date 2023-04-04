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

Console.Clear();
Console.WriteLine("Choose task number");
string task = Console.ReadLine()!;
if(task == "54")
{
    Console.WriteLine("Choose the size");
    int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    int [,] matrix = new int[size[0],size[1]];
    MatrixInput(matrix);
    MatrixPrinter(matrix);
    Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        int count = 0;
        while(count!=matrix.GetLength(1)-1)
        {
            count = 0;
            for(int j = 0; j < matrix.GetLength(1)-1;j++)
            {
                if(matrix[i,j] < matrix[i,j+1])
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,j+1];
                    matrix[i,j+1] = temp;
                    count = 0;
                }
                if(matrix[i,j] >= matrix[i,j+1])
                    count++;
            }
        }
    }
    MatrixPrinter(matrix);
}
if(task == "56")//в случае наличия двух строк с одинаковыми минимальными суммами прога выводит номер одной из них
{
    Console.WriteLine("Choose the size");
    int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    int [,] matrix = new int[size[0],size[1]];
    MatrixInput(matrix);
    MatrixPrinter(matrix);
    int min = 1000000;
    int RowNumber = 0;
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        int sum = 0;
        for(int j = 0; j <matrix.GetLength(1); j++)
        {
            sum+= matrix[i,j];
        }
        if(sum < min)
        {
            min = sum;
            RowNumber = i;
        }

    }
    Console.WriteLine($"Row {RowNumber+1}");
}
if(task == "58")
{
    Console.WriteLine("Reminder: the number of the columns of the first matrix must be equal to the number of the rows of the second matrix");
    Console.WriteLine();
    Console.WriteLine("Choose the size of the 1st matrix");
    int[] size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    int [,] matrix1 = new int[size1[0],size1[1]];
    MatrixInput(matrix1);
    Console.WriteLine("Choose the size of the 2nd matrix");
    Console.WriteLine();
    int[] size2 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
    int [,] matrix2 = new int[size2[0],size2[1]];
    MatrixInput(matrix2);
    if(size1[1] != size2[0])
        Console.WriteLine("Read the reminder one more time and try again but wiser");
    else
    {
        int [,] ResultMatrix = new int[size1[0],size2[1]];
        for(int i = 0; i < ResultMatrix.GetLength(0);i++)
        {
            for(int j = 0; j < ResultMatrix.GetLength(1); j++)
            {
                for(int f = 0; f < size1[1]; f++)
                {
                    ResultMatrix[i,j] += matrix1[i,f]*matrix2[f,j];
                }
            }
        }
        MatrixPrinter(matrix1);
        Console.WriteLine();
        MatrixPrinter(matrix2);
        Console.WriteLine();
        MatrixPrinter(ResultMatrix);
    }
}
if(task == "60")
{
    int[,,] array = new int[2,2,2];
    int n = new Random().Next(10,93);
    for(int x = 0; x < array.GetLength(0); x++)
    {
        for(int y = 0 ; y < array.GetLength(1); y++)
        {
            for(int z = 0; z < array.GetLength(2); z++)
            {
                array[x,y,z] = n;
                n++;
            }
        }
    }
    for(int x = 0; x < array.GetLength(0); x++)
    {
        for(int y = 0; y < array.GetLength(1); y++)
        {
            for(int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x,y,z]}({x},{y},{z})\t");
            }
            Console.WriteLine();
        }
    }
}
if(task == "62")// Я понимаю, что программа выглядит своеобразно, но прошу учесть, что в тз я уложился
{
    int[,] array = new int[4,4];
    int i = 0;
    int j = 0;
    int element = 0;
    while(j < array.GetLength(1))
    {
        element++;
        array[i,j] = element;
        j++;

    }
    j--;
    while(i < array.GetLength(0))
    {
        array[i,j] = element;
        element++;
        i++;
    }
    i--;
    while(j > 0)
    {
        j--;
        array[i,j] = element;
        element++;
    }
    while(i > 1)
    {
        i--;
        array[i,j] = element;
        element++;
    }
    while(j < 2)
    {
        j++;
        array[i,j] = element;
        element++;
    }
    array[2,2] = element;
    array[2,1] = element+1;
    MatrixPrinter(array);
    //P.S Я уверен, что можно было покрасивей программу изобразить, но пока только так получилось, всё-таки необычное для меня задание
}