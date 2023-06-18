using LinkedListDataStructure;
using System.Collections.Generic;

namespace LikedListDataStructure
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Choose Option To Perform\n1.Add To Linked List\n2.Reverse Added List\n3.Append The List\n4.Add In Between\n5.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                LinkedList list = new LinkedList();
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                        case 2:
                        list.AddReverse(70);
                        list.AddReverse(30);
                        list.AddReverse(56);
                        list.Display();
                        break;
                        case 3:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                        case 4:
                        list.Add(56);
                        list.Add(70);
                        list.InsertBetwen(1, 30);
                        list.Display();
                        break;
                        case 5:
                        flag= false;
                        break;
                }
            }
        }
    }
}
