using System;

namespace InterviewCake
{
    public  class BinaryTreeNode
    {

        public int value;
        public BinaryTreeNode left;
        public BinaryTreeNode right;

        public BinaryTreeNode(int value)
        {
            this.value = value;
        }

        public BinaryTreeNode insertLeft(int leftValue)
        {
            this.left = new BinaryTreeNode(leftValue);
            return this.left;
        }

        public BinaryTreeNode insertRight(int rightValue)
        {
            this.right = new BinaryTreeNode(rightValue);
            return this.right;
        }
    }

    public class SuperBalanced
    {

        public int isSuperBalanced(BinaryTreeNode head)
        {
            if (head == null)
                return 0;
           


            int leftHeight = 1 + isSuperBalanced(head.left);
               
            int rightHeight = 1;//+ isSuperBalanced(head.right);
                

        
            Console.WriteLine("rightbalaned=" + rightHeight + " leftbalanced=" + leftHeight);
            return 0;

        }



        int depth(BinaryTreeNode current)
        {
            int l = 0, r = 0;
            if (current.left != null)
            {

                l = depth(current.left);

            }

            if (current.right != null)
            {

                r = depth(current.right);

            }

            if (current.right == null && current.left == null)
            {

                return 1; //for leaf nodes

            }


            if (l > r)
                return l + 1;
            else
                return r + 1;
            
        }

        public void Tester()
        {
            BinaryTreeNode node1 = new BinaryTreeNode(1);
            BinaryTreeNode node2 = new BinaryTreeNode(2);
            BinaryTreeNode node3 = new BinaryTreeNode(3);
            BinaryTreeNode node4 = new BinaryTreeNode(4);
            BinaryTreeNode node5 = new BinaryTreeNode(5);
            BinaryTreeNode node6 = new BinaryTreeNode(6);
            BinaryTreeNode node7 = new BinaryTreeNode(7);
            BinaryTreeNode node8 = new BinaryTreeNode(7);

            node1.left = node2;
            node1.right = node3;
            //node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;
            node7.right = node8;

//            isSuperBalanced(node1);
            Console.Write(depth(node1));
        }

    }
}

