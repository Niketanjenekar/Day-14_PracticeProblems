using System.Collections.Generic;

namespace Day14_PracticeProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Problems: ");

            Linkedlist linkedlist = new Linkedlist();
            linkedlist.Push(56);
            linkedlist.Push(30);
            linkedlist.Push(70);

            linkedlist.Display();
        }
    }
}