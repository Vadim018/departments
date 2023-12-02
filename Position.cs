using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C2
{
    internal class Position : IID
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Position(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return String.Format("ID: " + Id + "     " + "NAME: " + Name + "     " + "SALARY: " + Salary);
        }
    }
}