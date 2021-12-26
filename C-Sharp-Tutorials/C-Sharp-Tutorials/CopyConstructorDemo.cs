using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorials
{
    internal class CopyConstructorDemo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CopyConstructorDemo(int _id, string _name)
        {
            Id = _id;
            Name = _name;
        }

        //Copy contructor
        public CopyConstructorDemo(CopyConstructorDemo copyConstructor)
        {
            Id = copyConstructor.Id;
            Name = copyConstructor.Name;
        }
    }
}
