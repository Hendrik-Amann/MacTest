using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList01
{
    class Program
    {
        static void Main( string [] args )
        {
            LinkedList l = new LinkedList();
            LinkedList.Node n1 = l.InsertAfter( null, 111 ); // An den Anfang
            l.Print();

            LinkedList.Node n2 = l.InsertAfter( n1, 222 ); // Hinter 111
            l.Print();

            LinkedList.Node n3 = l.InsertAfter( n2, 333 ); // Hinter 222
            l.Print();

            LinkedList.Node n2b = l.InsertAfter( n2, 299 ); //Zwischen 222 und 333
            l.Print();

            l.DeleteAfter( n1 ); // Entferne 222 (verbindet 111 und 299)
            l.Print();

            l.DeleteAfter( null ); // Entferne 111, erstes Element nun 299
            l.Print();

            l.DeleteAfter( n3 ); // Entfernt nichts, weil 333 das letzte Element ist
            l.Print();

            l.DeleteAfter( null ); // Entfernt ersten Knoten (299), nun ist 333 das erste (und einzige) Element
            l.Print();

            l.DeleteAfter( null ); // 333 wird auch entfernt
            l.Print(); // Liste ist nun leer

            Console.WriteLine("------------------------");
            l.Push(6);
            l.Print();
            l.Push(7);
            l.Push(1);
            l.Print();

            l.pop();
            l.Print();
            Console.WriteLine("test");


            Console.ReadLine();
        }
    }
}
