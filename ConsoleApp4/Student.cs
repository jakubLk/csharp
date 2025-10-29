using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{


    public string Meno { get; set; }

    public int Vek { get; set; }

    public string Adresa { get; set; }

    public char Pohlavie { get; set; }

    public bool IsAdult()
    {
        if (Vek >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
