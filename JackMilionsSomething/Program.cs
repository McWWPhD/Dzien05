using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackMilionsSomething
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random((int)DateTime.Now.Ticks);

            StringBuilder numbers = new StringBuilder();


            //5 of 50
            StringBuilder fiveNumbers = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {

                do
                {
                    byte number = (byte)random.Next(1, 51);
                    
                    if (i != 0) 
                    { 
                        fiveNumbers.Append(", "); 
                    }

                    fiveNumbers.Append(number);

                } while (!fiveNumbers.ToString().Contains(fiveNumbers.ToString()));

            }
            
            
            //2 of 10


            StringBuilder TwoNumbers = new StringBuilder();

            for (int i = 0; i < 2; i++)
            {

                do
                {
                    byte number = (byte)random.Next(1, 11);
                    
                    if (i != 0) 
                    { 
                        TwoNumbers.Append(", "); 
                    }
                    TwoNumbers.Append(number);

                } while (!TwoNumbers.ToString().Contains(TwoNumbers.ToString()));

            }


            Console.WriteLine("Five is: " + fiveNumbers +"\n"+ "Two numbers are: " + TwoNumbers );



        }
    }
}
