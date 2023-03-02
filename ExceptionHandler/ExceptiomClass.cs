using System;

namespace ExceptionHandler
{
    public class ExceptiomClass
    {
        public void example(int x, int y)
        {
           try
           {
             if (y <= 0)
             {
                 throw new ArithmeticException("Can not divide by zero");
             }
             else
             {
                 int z = x / y;
                 Console.WriteLine(z);
             }
           }
           catch (Exception e)
           {
            
            Console.WriteLine(e.Message);
           }
        }
    }
}
