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

            linkedlist.Display();
    }
}