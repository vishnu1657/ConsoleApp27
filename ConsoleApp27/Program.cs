
using System.Xml.Schema;

public class Program
{
    public static void Main()
    {
        pattern1();
        pattern2();
        pattern3();
        pattern4();
        pattern5();

        // WAP in C# using for loop??//

        static void pattern1()
        {
            for (int i = 1; i <= 10;  i++)
            {
                Console.Write(i);

            }   
            Console.WriteLine();


        }
       
       static void pattern2()
       {
            for (int i=0; i<=20;  i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
       }
    }
    static void pattern3()
    {
        for (int i = 30; i >= 1;  i--)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
    static void pattern4()
    {
        for (int i = 0; i<= 40; i=i+2)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
    
    static void pattern5()
    {
        for (int i =50; i >= 0; i = i - 2)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
    
}


