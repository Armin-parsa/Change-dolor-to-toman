using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //explains of changing number
            label4:
            Console.WriteLine("welcome to here");
            Console.WriteLine("you can find me with this email arminparsa789@gmail.com");
            Console.WriteLine("please just wright one charector for choosing your money");
            Console.WriteLine("a = dolor");
            Console.WriteLine("u = euro");
            Console.WriteLine("if you want change your name of money please enter number 001 and click on enter");
            Console.Write("enter your name of money: ");
            char nameofmoney = char .Parse(Console.ReadLine());
            char Dolor='a';
            char euro ='u';
            Console.WriteLine("ok wright your number for changing");
            //changing Dolor to toman
            if (nameofmoney == 'a')
            {
            label1:
                Console.ForegroundColor = ConsoleColor.Green;
                int y = 0;
                int x = 10;
                try
                {
                    while (y < x)
                    {
                        
                        int dolor = int.Parse(Console.ReadLine());
                        int toman = 110000;
                        Console.WriteLine(dolor * toman + " toman");
                        y += 1;
                        Console.ReadKey();
                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("you should write number for changing.");
                }
                Console.ReadKey();
                goto label1;
                
            }
            //changing Euro to toman 
            if (nameofmoney == 'u')
            {
            label2:
                Console.ForegroundColor = ConsoleColor.Green;
                int o = 0;
                int p = 10;
                try
                {
                    while (o < p)
                    {

                        int Euro = int.Parse(Console.ReadLine());
                        int toman = 4900;
                        Console.WriteLine(euro * toman + " toman");
                        o += 1;
                        Console.ReadKey();
                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("you should write number for changing.");
                }
                Console.ReadKey();
                goto label2;
               
            }


        }
    }
}










