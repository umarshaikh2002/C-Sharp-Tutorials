using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorials
{
    interface IStudent
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        void Add(Student student);
        void Edit(int id, Student student);
        void Remove(int id);
    }

    public abstract class A
    {
        abstract public void Add(Student student);
        abstract public void Edit(int id, Student student);
        public void Remove(int id)
        {
            //Body
        }
    }

    public class B : A
    {
        public override void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public override void Edit(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }

    class C
    {
        public void M1()
        {
            B a = new B();
            a.Remove();
        }
    }
}
