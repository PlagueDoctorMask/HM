// в заданиях не указано требуемое кол-во элементов массива, пусть будет 10:)
Console.WriteLine("Choose task number");
string task = Console.ReadLine()!;
if(task == "34")
{
    int NumbersCounter (int[] array)
    {
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i]%2 == 0)
            count+=1;
        }
        return count;
    }

    int[] array = new int[10];
    for(int i = 0; i < 10; i ++)
    {
        array[i] = new Random().Next(99,1000);
    }
    Console.WriteLine($"[{string.Join("," , array)}]");
    Console.WriteLine(NumbersCounter(array));

}
if(task == "36")
{
    int NumbersFinder (int[] array)
    {
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(i%2 != 0)
            count+=array[i];
        }
        return count;
    }

    int[] array = new int[10];
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(1,11);
    }
    Console.WriteLine($"[{string.Join("," , array)}]");
    Console.WriteLine(NumbersFinder(array));
}
if(task == "38")
{
    double NumbersSummer (double[] array)
    {
        double max = -10000000;
        double min = 10000000;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > max)
            max = array[i];
            if(array[i] < min)
            min = array[i];
        }
        return max - min;
    }

    double[] array = new double[10];
    Random random = new Random();
    for(int i = 0; i < 10; i ++)
    {
        array[i] = random.NextDouble() * 100;
    }
    Console.WriteLine($"[{string.Join("," , array)}]");
    Console.WriteLine(NumbersSummer(array));
}