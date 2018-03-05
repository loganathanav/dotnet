using System;
using Learn.Core.Basic;

namespace Learn.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Node five = new Node(5, null);
            Node four = new Node(4, five);
            Node three =  new Node(3, four);
            Node two =  new Node(2, three);
            Node one =  new Node(1,two);

           // var nodes = new Node[one, two, three, four, five];

            PrintNode(one);
            Console.ReadLine();
        }

        static void PrintNode(Node node)
        {
            while (node != null)
            {
                
                System.Console.WriteLine($"Node {node.Value} {(node.Next == null) ? "has no pointers" : $"points to {node.Next.Value.ToString() } " }");
                node = node.Next;
            }
        }
    }
}
