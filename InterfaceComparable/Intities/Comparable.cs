using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceComparable.Intities
{
    class Comparable
    {
        internal List<EmployeeList> NameList = new List<EmployeeList>();

        public void SetListName(string path)
        {
            try
            {
                using (StreamReader Sreader = File.OpenText(path))
                {
                    while (!Sreader.EndOfStream)
                    {
                        NameList.Add(new EmployeeList(Sreader.ReadLine()));
                    }
                }
            }
            catch( IOException e)
            {
                Console.WriteLine("An error occurred" + e.Message);
            }
        }

        public void DisplayOrderedNames()
        {
            NameList.Sort();
            foreach(var employee in NameList)
            {
                Console.WriteLine(employee);
            }
        }

    }
}
