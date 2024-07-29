using KeyValueArr;
using System;

namespace GenericKeyValueDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeyValDB<int, string> keyValDB = new KeyValDB<int, string>();
            keyValDB.Add(0, "a");
            keyValDB.Add(1, "b");
            keyValDB.Add(2, "c");
            keyValDB.Remove(0);
            keyValDB.PrintDB();
            Console.Write("Value for key 1 is : ");
            keyValDB.TryGet(1, out string value);
            Console.WriteLine(value);
            Console.ReadKey();  
        }
    }
}
