using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace day6_LinkedList{
    public class Program{
        public static void Main(string[] args)
        {
            Linkedlist linkedlist = new Linkedlist();
            linkedlist.reverseInsert(70);
            linkedlist.reverseInsert(30);
            linkedlist.reverseInsert(56);

            linkedlist.Display();

        }
    }
}