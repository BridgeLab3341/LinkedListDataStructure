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
                Console.WriteLine("Choose Option To Perform\n1.Add To Linked List\n2.Reverse Added List\n3.Append The List\n4.Add In Between\n5.Delete First Element\n6.Delete Last Element\n7.Search Node\n8.Insert Node in LinkedList\n9.Delete Node At Particular Position\n10.Sort in Ascending Order\n11.Exit");
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
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.DeleteFirstElement();
                        list.Display();
                        break;
                        case 6:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.DeleteLastElement();
                        list.Display();
                        break;
                        case 7:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.SearchNode(30);
                        list.Display();
                        break;
                    case 8:
                        list.Add(56);
                        list.Add(30);
                        list.InsertBetwen(2, 40);
                        list.Add(70);
                        list.Display();
                        break;
                    case 9:
                        list.Add(56);
                        list.Add(30);
                        list.InsertBetwen(2, 40);
                        list.Add(70);
                        list.Display();
                        list.DeleteNodeAtParticularPosition(2);
                        list.Display();
                        list.Size();
                        break;
                        case 10:
                        list.Add(56);
                        list.Add(30);
                        list.Add(40);
                        list.Add(70);
                        list.Sort();
                        list.Display();
                        break;
                        case 11:
                        flag= false;
                        break;
                }
            }
        }
    }
}
