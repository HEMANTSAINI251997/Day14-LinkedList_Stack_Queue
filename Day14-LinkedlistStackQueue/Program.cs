using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_LinkedlistStackQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListDemo linkedListDemo = new LinkedListDemo();

            while (true)
            {
                Console.WriteLine("1. UC1-Simple Linked List");
                Console.WriteLine("2. UC2-Add values in Linked List");
                Console.WriteLine("3. UC3-Reverse Linked List");
                Console.WriteLine("4. UC4-Insert 30 between 56 & 70");
                Console.WriteLine("5. UC-5 Delet First element 56");
                Console.WriteLine("6. UC-6 Delet Last element");
                Console.WriteLine("Enter your Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedListDemo.CheckLinkedList();
                        break;
                    case 2:
                        linkedListDemo.Add(70);
                        linkedListDemo.Add(30);
                        linkedListDemo.Add(56);
                        linkedListDemo.Display();
                        break;
                    case 3:

                        linkedListDemo.Reverse(56);
                        linkedListDemo.Reverse(30);
                        linkedListDemo.Reverse(70);
                        Console.WriteLine("After Reverse");
                        linkedListDemo.Display();
                        break;
                    case 4:
                        linkedListDemo.Add(56);
                        linkedListDemo.Add(70);
                        linkedListDemo.InsertData(30, 56);
                        linkedListDemo.Display();
                        break;
                    case 5:
                        linkedListDemo.FirstNode();
                        linkedListDemo.Display();
                        break;
                    case 6:
                        linkedListDemo.LastNode();
                        linkedListDemo.Display();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }
    }
}









