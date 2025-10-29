internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>();

        bool running = true;
        while (running)
        {
            string command = Console.ReadLine();
            switch (command)

            {
                case "add":
                    {
                    AddNumber: (list);
                        break;
                    }
                case "del":
                    {
                        Console.WriteLine("What number do you want to delete");
                        string number = Console.ReadLine();
                        int numberint = int.Parse(number);
                        list.Remove(numberint);
                        break;
                    }
                case "deli":
                    {
                        Console.WriteLine("The number at what position do you want to remove");

                        string number = Console.ReadLine();
                        int numberint = int.Parse(number);
                        if (numberint >= 0 && numberint < list.Count)
                        {
                            list.RemoveAt(numberint);
                        }
                        else
                        {
                            Console.WriteLine("bad index");
                        }

                        break;
                    }
                case "end":
                    {
                        //running = false;
                        break;
                    }
                case "list":
                    {
                        foreach (int i in list)
                        {
                            Console.WriteLine(i);
                        }

                        break;
                    }
                case "has":
                    {
                        Console.WriteLine("What number do you want to check if the list has?");
                        string number = Console.ReadLine();
                        int numberint = int.Parse(number);
                        bool hasnumberint = list.Contains(numberint);
                        if (hasnumberint)
                        {
                            Console.WriteLine("true");
                        }
                        else
                        {
                            Console.WriteLine("false");
                        }

                        break;
                    }
                case "count":
                    {
                        int sum = 0;
                        foreach (int i in list)
                        {
                            sum += i;
                            Console.WriteLine(sum);
                        }

                        break;
                    }
                case "avg":
                    {
                        int sum = 0;
                        foreach (int i in list)
                        {
                            sum += i;

                        }

                        int sum1 = sum / list.Count;
                        Console.WriteLine(sum1);
                        break;
                    }
                case "max":
                    {
                        int max = list[0];

                    }

             
                }
            }
        }
    }
}

    
