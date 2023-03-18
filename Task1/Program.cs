//Все задачи работают только с целыми числами
Console.WriteLine("Choose task number");
string ?task = Console.ReadLine();
if(task == "2")
{
    int a,b;
    Console.WriteLine("enter the first number");
    a = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the second number");
    b = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"Max number is {Math.Max(a,b)}");//Я знаю, что можно использовать условия, просто сэкономил строчки
    Console.WriteLine($"Min number is {Math.Min(a,b)}");//Добавил условия в 4 задаче
}
if(task == "4")
{
    int a,b,c,min,max;
    Console.WriteLine("enter the first number");
    a = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the second number");
    b = Int32.Parse(Console.ReadLine());
    Console.WriteLine("enter the third number");
    c = Int32.Parse(Console.ReadLine());
    max = Math.Max(a,b);
    min = Math.Min(a,b);
    if(max > c)
        Console.WriteLine($"Max number is {max}");
    else
        Console.WriteLine($"Max number is {c}");
    if(min < c)
        Console.WriteLine($"Min number is {min}");
    else
        Console.WriteLine($"Min number is {c}");
}
if(task == "6")
{
    Console.WriteLine("enter the number");
    if(Int32.Parse(Console.ReadLine())%2==0)
        Console.WriteLine("number is even");
    else
        Console.WriteLine("number is odd");
}
if(task == "8")//не работает с отрицательными числами
{
    int a;
    int count = 2;
    Console.WriteLine("enter the number");
    a = Int32.Parse(Console.ReadLine());
    while(a >= count)
    {
        Console.WriteLine(count);
        count = count + 2;
    }

}
