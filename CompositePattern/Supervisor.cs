using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    public class Supervisor: IPeople
    {
        private readonly List<IPeople> m_lsStudent = new List<IPeople>();
        public string Name { get; set; }

        public void addStudent(IPeople employed)
        {
            m_lsStudent.Add(employed);
        }

        public void removeStudent(IPeople employed)
        {
            m_lsStudent.Remove(employed);
        }

        public IPeople getStudent(int index)
        {
            return m_lsStudent[index];
        }

        public void Render(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            foreach (var student in m_lsStudent)
            {
                student.Render(depth + 1);
            }
        }
    }
}
