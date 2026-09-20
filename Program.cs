using System;
using System.Runtime.Serialization.Formatters;
class Program
{
    static void Main()
    {
        string[] mass = Console.ReadLine().Split();
        int one = int.Parse(mass[0]);
        int two = int.Parse(mass[1]);
        int three = int.Parse(mass[2]);
        int max = one;
        int min = two;
        if (two > max) 
        { 
            max = two;
            min = one;
        }
        if (three > max) 
        {
            max = three; 
        }
        else if (three < min)
        {
            min = three;
        }



        Console.WriteLine($"max = {max}, min ={min}, разница = {max-min}");
    }
}
