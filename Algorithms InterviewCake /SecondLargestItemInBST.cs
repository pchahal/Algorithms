using System;

namespace InterviewCake
{
    

    public class SecondLargestItemInBST
    {
        public int FindSecondLargestItemInBST(BinaryTreeNode head)
        {
            if (head == null)
                return -1;
            
            if (head.right != null)
            {
                //if rightchild is leaf headnode is 2nd largest
                if (head.right.left == null && head.right.right == null)
                    return head.value;
                else
                    return FindSecondLargestItemInBST(head.right);
            } 
            
            else if (head.left != null)
            {
                if (head.left.left == null && head.left.right == null)
                    return head.value;
                 else
                    return FindSecondLargestItemInBST(head.left);
            }

            return head.value;

        }






        //    5

        //  2         (7)

        // 1   3     6   8
        public void Tester()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(5);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(7);

            BinaryTreeNode node4 = new BinaryTreeNode(1);
            BinaryTreeNode node5 = new BinaryTreeNode(3);
            BinaryTreeNode node6 = new BinaryTreeNode(6);
            BinaryTreeNode node7 = new BinaryTreeNode(8);

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            //node3.left = node6;
            //node3.right = node7;

            Console.WriteLine("hi");
            Console.Write(FindSecondLargestItemInBST(node1));
        }
    }
}

