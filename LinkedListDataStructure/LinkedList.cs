using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                head = node;
            }
            else
            {
                Node temp= head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine("{0} inserted into the LinkedList",node.data);
        }
        public void AddReverse(int data)
        {
            Node newNode= new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp= this.head;
                head = newNode;
                head.Next = temp;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "  ");
                temp = temp.Next;
            }
        }
        public void InsertBetwen(int position, int data)
        {
            Node newestnode= new Node(data);
            if(this.head == null)
            {
                this.head = newestnode;
            }
            if(position == 0)
            {
                newestnode.Next = this.head;
                this.head = newestnode;
                return;
            }
            Node prev = null;
            Node current= this.head;
            int count = 0;
            while(current != null && count < position)
            {
                prev=current;
                current = current.Next;
                count++;
            }
            newestnode.Next = prev.Next;
            prev.Next = newestnode;
        }
        public void DeleteFirstElement()
        {
            if(this.head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            this.head = this.head.Next;
        }
    }
}
