using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				try
				{
					//problematyczny kod
					int i = 0, j = 0, k = 0;
					//k = i / j;
					string s1 = Console.ReadLine();
					int x = Int32.Parse(s1);

					string s2 = Console.ReadLine();
					sbyte y = SByte.Parse(s2);

					Console.WriteLine(x / y);

					if (y == 1)
					{
						throw new Exception("Sorry, wartoś 1 nie jest dozwolona");
					}

				}
				catch (OverflowException exc)
				{
					Console.WriteLine("Przepełnienie: {0}", exc.Message);

				}
				catch (ArithmeticException exc)
				{
					// obsługa wyjątku
					Console.WriteLine("Wytąpił wyjątek arytmetyczny: {0}", exc.Message);
				}
				catch (FormatException exc)
				{
					Console.WriteLine("Zły format: {0}", exc.Message);
					throw;
				}
				catch (Exception exc)
				{
					Console.WriteLine("general error: {0}", exc.Message);
				}
				finally
				{
					Console.WriteLine("To się zawsze wykona");
				}

			} catch (Exception exc)
			{

				Console.WriteLine("Wyjątek zewnętrzny: {0}", exc.Message);
			}
			Console.ReadKey();
        }
    }
}
