Console.Clear();
Console.WriteLine("Choose task number");
string task = Console.ReadLine()!;
if(task == "64")
{
    string Num (int n)
    {
        string result = string.Empty;
        for(int i = 1; i <= n; i++)
        {
            result = $"{i}" + " " + result;
        }
        return result;
    }

    Console.WriteLine("Choose a number");
    int N = int.Parse(Console.ReadLine()!);
    Console.WriteLine(Num(N));

}
if(task == "66")
{
    int Sum(int a, int b)
    {
        int result = 0;
        for(int i = a; i <= b; i++) result+= i;
        return result;
    }
    Console.WriteLine("Choose a 1st number");
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Choose a 2nd number");
    int b = int.Parse(Console.ReadLine()!);
    Console.WriteLine(Sum(a,b));
}
if(task == "68")
{
    int Ackerman (int m, int n)
    {
        if (m == 0) return n + 1;
        if (m != 0 && n == 0) return Ackerman(m - 1, 1);
        if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
        return Ackerman(m,n);
    }
    Console.WriteLine("Choose a 1st number");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Choose a 2nd number");
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(Ackerman(m,n));
}