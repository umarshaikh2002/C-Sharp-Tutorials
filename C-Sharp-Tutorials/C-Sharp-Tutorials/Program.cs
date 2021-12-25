using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFile file1 = new File();

            File file2 = new File();

            file1.ReadFile();

            file1.WriteFile("Hello");

            file2.ReadFile();

            Console.ReadKey();
        }   
    }

    class File : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Read file");
        }

        public void WriteFile(string text)
        {
            throw new NotImplementedException();
        }
    }

    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }
}
