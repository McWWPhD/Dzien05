using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlikiFoldery
{
    class Program
    {
        static void Main(string[] args)
        {
            //foldery


            string folderName = @"C:\tmp\alx";

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }



            Directory.Move(folderName, @"C:\tmp\csharp");

            Directory.Delete(@"C:\tmp\csharp", true);


            CopyDir(@"C:\tmp", @"C:\tmp2");




            //pliki
            string path = @"C:\tmp\plik.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            StreamWriter sw = File.CreateText(path);
            sw.Close();

            File.WriteAllText(path, "Ala ma kota, a kot ma kleszcze");
            File.Copy(path, @"C:\tmp\plik2.txt", true);
            File.Move(@"C:\tmp\plik2.txt", @"C:\tmp\plik3.txt");

            string s = File.ReadAllText(path);
            Console.WriteLine(s);
            Console.ReadKey();


        }

        static void CopyDir(string sourceDir, string targetDir)
        {
            if(!sourceDir.EndsWith(@"\") )
            {
                sourceDir += @"\";
            }

            if (!targetDir.EndsWith(@"\"))
            {
                targetDir += @"\";
            }

            //pobierz wszystkie pliki i nazwy podfolderów z sourceDir

            string[] files = Directory.GetFileSystemEntries(sourceDir);

            Directory.CreateDirectory(targetDir);

            for (int i = 0; i < files.Length; i++)
            {
                string srcFile = files[i];
                Console.WriteLine(srcFile);
                FileAttributes attr = File.GetAttributes(srcFile);


                if (attr == FileAttributes.Directory)
                {
                    //obsługa rekurencyjna kopiowania folderów
                    string newFolder = targetDir + Path.GetDirectoryName(srcFile);
                    if (!Directory.Exists(targetDir))
                    {
                        Directory.CreateDirectory(targetDir);

                    }
                    CopyDir(srcFile, newFolder);

                }

                else
                {
                    //kopiowanie pliku
                    File.Copy(srcFile, targetDir + Path.GetFileName(srcFile));

                }
            }
        }
    }
}
