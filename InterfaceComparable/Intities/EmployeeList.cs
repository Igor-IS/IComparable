using System.Globalization;
using System;

namespace InterfaceComparable.Intities
{
    class EmployeeList : IComparable
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public EmployeeList(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(",");
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "Name: " + Name + ", R$" + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is EmployeeList)) // se obj não for do type Employee
            {
                throw new ArgumentException("Comparing error: argument is not an employee");
            }
            EmployeeList other = obj as EmployeeList;
            return Salary.CompareTo(other.Salary); // defini o que será comparado Name or Salary
        }
    }
}
