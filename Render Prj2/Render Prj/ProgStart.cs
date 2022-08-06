using System;
using System.Collections.Generic;
using System.IO;
using RendObj;

namespace Render_Prj
{

    


    class ProgStart
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"Enter the Path(like: C:\Users\tomfitz )");
            DirectoryInfo direct;
            FileInfo[] dirF;
            while (true) 
            {
                try
                {
                    string path = @Console.ReadLine();
                    direct = new DirectoryInfo(path);
                    dirF = direct.GetFiles();
                    break;
                }
                catch
                {
                    Console.WriteLine("Pls try again.");
                }
            }
            if (dirF.Length > 0)
            {
                List<RenderObj> Files = new List<RenderObj>();
                int i = 0;
                foreach (var fi in dirF)
                {
                    Console.WriteLine("{0}- {1}",i,fi);
                    Files.Add(new RenderObj(fi));
                    i++;
                }
                Console.WriteLine("Enter the number of file.");
                var try_i = Console.ReadLine();
                int num = -1;
                while (!((int.TryParse(try_i, out num)) && num >= 0 && num <= dirF.Length-1))
                {
                    Console.WriteLine("Pls try again.");
                    try_i = Console.ReadLine();
                }
                Files[num].Printer();
            }

            Console.ReadLine();
        }
    }
}
