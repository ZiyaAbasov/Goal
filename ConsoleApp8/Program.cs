using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int start = 6;
            int end = 14;
            int ODDcount = 0;
            for (int i = 0; i < num.Length; i++)
            {
              
                if (start < num[i] && num[i] < end)
                {
                    
                    if (num[i] % 2 == 1) 
                    {
                        ODDcount++;

                        Console.WriteLine("Odd number count " + ODDcount);
                    }


                    


                }

              
            }
        }
        

            
        
    }
}   
