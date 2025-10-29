using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum1 = Console.ReadLine(5);
        int sum2 = Console.ReadLine(10);
        Console.WriteLine(sum1);
        Console.WriteLine (sum2);
        int sum = Scitanie((sum1) ,(sum2) ,2, 3, 5);
        
        Console.WriteLine(sum);

    }
    public static int Scitanie (int a , int b , int c , int d , int e)
    {
        int f = a + b + c + d + e;
        return f;

    }
}