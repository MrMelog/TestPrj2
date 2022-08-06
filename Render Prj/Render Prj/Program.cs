using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Render_Prj
{
    
    class RenderObj
    {
        private string _fullname = "";
        private Int64 _lenght;
        private string _extension = "";
        private string _name = "";

        public FileInfo _file;

        public void Inform()
        {
          
            _lenght = _file.Length;
            _fullname = _file.FullName;
            _extension = _file.Extension;
            _name = _file.Name;
            //Console.WriteLine("Saved");
        }

        public void Printer()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_fullname);
            Console.WriteLine(_extension);
            Console.WriteLine("{0} byte", _lenght);

        }

        public void FilInf(FileInfo inf)
        {
            _file = inf;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"Enter the Path(like: C:\Users\tomfitz )");
            //string path = Console.ReadLine();
            string path = @"F:\Files";
            DirectoryInfo di = new DirectoryInfo(path);
            var dire = di.GetFiles();
            if (dire.Length > 0)
            { 
                RenderObj[] Files = new RenderObj[dire.Length];
                int i = 0;
                foreach (var fi in dire)
                {
                    Console.WriteLine("{0}-{1}",i,fi);
                    Files[i] = new RenderObj();
                    Files[i]._file = fi;
                    i++;
                }
                Console.WriteLine("Enter the number of file.");
                var try_i = Console.ReadLine();
                int num = -1;
                while (!((int.TryParse(try_i, out num)) && num >= 0 && num <= dire.Length))
                {
                    Console.WriteLine("Pls try again.");
                    try_i = Console.ReadLine();
                }
                Files[num].Inform();
                Files[num].Printer();
            }

            Console.ReadLine();
            /*FileInfo file = new FileInfo(@"F:\World1.obj");
            Console.WriteLine("{0} byte", file.Length);
            Console.WriteLine(file.FullName);
            Console.WriteLine(file.Extension);
            Console.WriteLine(file.Name);
            FileInfo file1 = new FileInfo(@"F:\Files\");
            Console.WriteLine(file);
            

            DirectoryInfo di = new DirectoryInfo(@"F:\Files\");
            Console.WriteLine("No search pattern returns:");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi);
            }*/



        }
    }
}
