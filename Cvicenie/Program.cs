using System;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        string[] text = File.ReadAllLines("People_100.csv");
    }

    public static void MoneyCountAverage(string[] text)
    {
        int sum = 0;
        foreach (string line in text.Skip(1))
        {
            // Martin,Urban,690602/2315,Presov,463102,slobodny
            string[] splits = line.Split(",");
            // prekonvertovanie hodnoty z retazca na cislo
            int accountValue = int.Parse(splits[4]);
            // scitanie int hodnoty so sum-om
            sum += accountValue;
        }

        Console.WriteLine(sum / (text.Count() - 1));
    }

    public static void WriteRodneCislo(string[] text)
    {
        int sum = 0;
        foreach (string line in text.Skip(1))
        {
            // Martin,Urban,690602/2315,Presov,463102,slobodny
            string[] splits = line.Split(",");
            string birthNumber = splits[2];
            Console.WriteLine(birthNumber);
        }
    }
}
public static void WriteRodneCislo(string[] text)
{
    int sum = 0;
    foreach (string line in text.Skip(1))
    {
        //Martin,Urban,690602/2315,Presov,463102,slobodny
        string[] splits = line.Split(";");
        string birthNumber = splits[2];
        Console.WriteLine(birthNumber);
    }
}























