using System;

namespace IterationStatementsDemo
{
    internal class Program
    {
        public static bool CanVote()
        {
            
                bool canParse = false;
                int age;

                while (!canParse)
                {
                    Console.WriteLine("Please enter your age:");
                    canParse = int.TryParse(Console.ReadLine(), out age);

                        if (age >= 18)
                        {
                            Console.WriteLine("yoi are old enough to vote");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("sorry youre not old enough to vote");
                            return false;
                        }

                }
            return canParse;
        }

             
        
        static void Main(string[] args)
        {
            //for(int i = 5; i <= 100; i+= 10)
            //{
            //    Console.WriteLine(i);
            //}
            CanVote();

            Console.WriteLine("Prints numbers 100 to 0");
            for(var i=100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("prints out array's 1 to 5 using foreach loop");

            var myArr = new int[]{ 1, 2, 3, 4, 5 } ;

            foreach (var num in myArr)
             {
                   Console.WriteLine(num); 
             }
            Console.WriteLine();
            Console.WriteLine("prints out array's 1 to 5 using for loop");
            for (var i=0; i< myArr.Length; i++)
          {
             Console.WriteLine(myArr[i]);
          }
            int x = 0;
            while (x < 18)
            {
                Console.WriteLine(x);
                x++;
            }
                
               

             
            
        }

    }
}
