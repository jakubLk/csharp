using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("z akeho tvaru chces to mat ");
        string znak = Console.ReadLine();
        Console.Write("aky velky chces mat trojuholnki");
        string velkost = Console.ReadLine();
        int velkostDva = int.Parse(velkost);
        for (int i = 1; i <= velkostDva; i++)
        {
            string row = "";
            for (int j = 1; j <= i; j++)
            {
                row += znak;
            }
            Console.WriteLine(row);
        }
    }
}

















