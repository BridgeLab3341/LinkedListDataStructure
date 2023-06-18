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
        public void DeleteLastElement()
        {
            if(this.head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            Node node2= head;
            if(head.Next == null)
            {
                this.head = null;
            }
            while(node2.Next.Next != null)
            {
                node2 = node2.Next;
            }
            node2.Next = null;
        }
        public int SearchNode(int value)
        {
            Node node = this.head;
            int count = 0;
            while(node != null)
            {
                if(node.data.Equals(value))
                {
                    Console.WriteLine(count);
                }
                node = node.Next;
                count++;
            }
            return count;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.Next;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }
            if (temp == null || temp.Next == null)
            {
                return;
            }
            Node next = temp.Next.Next;
            temp.Next = next;
            Size();
        }
        public void Size()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine("Size is " + count);
        }
    }
}
