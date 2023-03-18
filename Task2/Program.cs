Console.WriteLine("Choose task number");
string ?task = Console.ReadLine();
if(task == "19")
{
    int N;
    Console.WriteLine("enter the number");
    N = Int32.Parse(Console.ReadLine());
    int n1,n2,n4,n5;
    n1 = N/10000;
    n2 = (N/1000)%10;
    n4 = (N%100)/10;
    n5 = N%10;
    if(n1 == n5 && n2 == n4)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}
if(task == "21")
{
    int x1,y1,z1,x2,y2,z2;
    Console.WriteLine("enter the X coordinate of the first point");
    x1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the Y coordinate of the first point");
    y1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the Z coordinate of the first point");
    z1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the X coordinate of the second point");
    x2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the Y coordinate of the second point");
    y2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the Z coordinate of the second point");
    z2 = Int32.Parse(Console.ReadLine());
    Console.WriteLine($" The length between your points is {Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2)}");
}
if(task == "23")
{
    int N;
    Console.WriteLine("enter the number");
    N = Int32.Parse(Console.ReadLine());
    for(int i = 1; i <= N; i++)
    {
        Console.WriteLine(i*i*i);
    }
    
}