using LinkedLsit.Model;
using System;

namespace LinkedLsit
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
