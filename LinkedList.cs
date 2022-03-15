using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList01
{
    class LinkedList
    {
        public class Node
        {
            //Wert
            public object Value { get; set; }
            //Link zum Nächsten
            public Node Next { get; set; }

            public Node() { }
            public Node( object val )
            {
                this.Value = val;
            }
        }

        //warum private?
        private Node head;
        int Count = 0;

        public Node InsertAfter( Node prevNode, object value )
        {
            Node n = new Node( value );
            if ( prevNode == null )
                head = n;
            else
            {
                //übernehme next vom Vorgänger
                n.Next = prevNode.Next;
                //werde next vom Vorgänger
                prevNode.Next = n;
            }
            Count++;
            return n;
        }

        public void DeleteAfter( Node prevNode )
        {
            //wenn kein prevNode übergeben wird, dann wird der erste gelöscht
            if ( prevNode == null )
            {
                // Erster Knoten soll entfernt werden
                if ( head != null )
                    head = head.Next;
            }
            else
            {
                //nicht übergebene wird gelöscht, sondern after
                Node nodeToBeDeleted = prevNode.Next;
                if ( nodeToBeDeleted != null )
                {
                    Node newNext = nodeToBeDeleted.Next;
                    prevNode.Next = newNext;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine( "--- Linked List ---" );
            Node n = head;
            while ( n != null )
            {
                Console.WriteLine( n.Value );
                n = n.Next;
            }
        }

        public bool isEmpty()
        {
            return (head == null);
        }

        public int Size()
        {
            return Count;
        }

        public void Push(object value)
        {
            if(head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node temp = head;
                head = new Node(value);
                head.Next = temp;
            }
            Count++;
        }

        public void pop()
        {
            if(head != null)
            {
                head = head.Next;
                Count--;
            }
        }
    }
}
