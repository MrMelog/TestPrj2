using System;
using Program;

public class Class1
{
    public class RenderObj
    {
        private string _fullname = "";
        private Int64 _lenght;
        private string _extension = "";
        private string _name = "";

        public RenderObj(FileInfo fileInf)
        {
            _fullname = fileInf.FullName;
            _lenght = fileInf.Length;
            _extension = fileInf.Extension;
            _name = fileInf.Name;
        }

        public void Printer()
        {
            Console.Write(
                "Name: {0} \n" +
                "Path: {1} \n" +
                "Format: {2} \n" +
                "Size: {3} byte", _name, _fullname, _extension, _lenght);
        }

    }
}
