using System;

namespace CTCI
{
    //Sum Lists: You have two numbers represented by a linked list, where each node
    // contains a single digit. The digits are stored in reverse order, such that
    // the 1's digit is at the head of the list. Write a function that adds the two 
    //numbers and returns the sum as a linked list.
    //EXAMPLE
    //Input: (7-) 1 -) 6) + (5 -) 9 -) 2).Thatis,617 + 295. 
    //Output: 2 -) 1 -) 9.That is, 912.
    class SumLists
    {

        public int getNumber(Node link1)
        {
            int num1 = 0;
            int i = 0;
            while (link1 != null)
            {
                int tens = (int)Math.Pow(10, i);
                num1 += tens * link1.data;
                i++;
                link1 = link1.next;
            }
            return num1;

        }
        public Node Sum(Node link1, Node link2)
        {
            int num1 = getNumber(link1);
            int num2 = getNumber(link2);

            int sum = num1 + num2;//912


            string sumString = sum.ToString();
            Node sumList = new Node(int.Parse(sumString[0].ToString()));

            int i = 1;
            while (i < sumString.Length)
            {

                int value = int.Parse(sumString[i].ToString());
                sumList.appendToTail(value);
                i++;
            }

            return sumList;
        }

        public void Test()
        {
            Node a = new Node(7);
            a.appendToTail(1);
            a.appendToTail(6);
            Node b = new Node(5);
            b.appendToTail(9);
            b.appendToTail(2);
            Sum(a, b);
        }

    }


}

