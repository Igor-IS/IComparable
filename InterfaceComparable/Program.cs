using InterfaceComparable.Intities;
using System;

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathTheNames = @"C:\Users\Igorv\Documents\CSharp\InterfaceComparable\file.txt";
            var setPath = new Comparable();
            setPath.SetListName(pathTheNames);
            setPath.DisplayOrderedNames();
        }
    }
}
