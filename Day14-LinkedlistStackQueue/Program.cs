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
          //  linkedListDemo.CheckLinkedList();

            linkedListDemo.Add(70);
            linkedListDemo.Add(30);
            linkedListDemo.Add(56);
            linkedListDemo.Display();
        }
    }
}
