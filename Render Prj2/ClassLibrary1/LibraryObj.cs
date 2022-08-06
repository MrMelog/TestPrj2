using System;
using System.IO;

namespace RendObj
{
    public class RenderObj
    {
        private string _fullname = String.Empty;
        private Int64 _lenght;
        private string _extension = String.Empty;
        private string _name = String.Empty;

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
