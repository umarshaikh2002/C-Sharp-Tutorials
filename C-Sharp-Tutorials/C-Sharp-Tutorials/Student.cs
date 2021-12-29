using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorials
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Class { get; set; }
        public float Percentage { get; set; }

        public Student()
        {
            this.Students = new List<Student>();
        }

        public List<Student> Students { get; set; }

        public void Add(Student student)
        {
            this.Students.Add(student);
        }

        public void Edit(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            return this.Students.Find(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            return this.Students;
        }

        public void Remove(int id)
        {
            Student std = this.Students.Find(x => x.Id == id);

            if(std != null)
                this.Remove(std.Id);
        }
    }
}
