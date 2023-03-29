using System.Collections.Generic;

namespace Day14_PracticeProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Problems: ");

            //Linkedlist linkedlist = new Linkedlist();
            LinkedLIstQueue linkedlist = new LinkedLIstQueue();
            linkedlist.Enqueue(56);
            linkedlist.Enqueue(30);
            linkedlist.Enqueue(70);
            Console.WriteLine("*******************************************************");
            linkedlist.Display();
            Console.WriteLine("*******************************************************");
            linkedlist.Dequeue();
            Console.WriteLine("*******************************************************");
            linkedlist.Display();
            Console.WriteLine("*******************************************************");
            Console.ReadLine();







            //Console.WriteLine("**************************************************");
            //Console.WriteLine("Now the stack contains : ");

            //linkedlist.Display();

            //linkedlist.Peak();
            //linkedlist.Pop();

            //linkedlist.Display();
            //linkedlist.Peak();
        }
    }
}