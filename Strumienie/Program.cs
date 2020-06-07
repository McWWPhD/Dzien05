using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Strumienie
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(@"C:\tmp\test.txt");
                sw.AutoFlush = true;       //zamiast sw.Flush() na końcu;
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine(String.Format("Linia nr {0}", i));
                }
                //sw.Flush();
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (sw !=null)
                {
                    //zamykanie strumienia
                    sw.Close();
                }                 
            }

            //using - resourse menager / context menager
            try
            {
                using (StreamWriter sw1 = new StreamWriter(@"C:\tmp\test1.txt")) 
                {
                sw1.Write("ABCD");
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
            String s = null;
            // odczyt danych za pomocą klasy FileStream
            string path = @"C:\tmp\test.txt";
            byte[] data;
            if (File.Exists(path) )
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();

                // konwersja tablicy bajtów na string
                s = Encoding.UTF8.GetString(data);
                Console.WriteLine(s);
            }

            //odczyt dany w sposób sekwencyjny (linia po lini)
            StreamReader sr = new StreamReader(path);
            string result = "";
            StringBuilder sb = new StringBuilder(100);
            
            do
            {
                s = sr.ReadLine();
                //zamiast :   result += s + Environment.NewLine;
                sb.AppendLine(s);


            } while (s != null);
            Console.WriteLine(sb.ToString());

            

        }
    }
}
