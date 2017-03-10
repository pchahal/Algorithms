using System;

namespace InterviewCake
{
    public class ValidSearchTree
    {


        // tree is valid if nodeleft< Node< nodeRight
        public bool isValidSearchTree(BinaryTreeNode head)
        {

            if (head == null)
                return true;
            if (head.left == null && head.right == null)
                return true;
            


            bool left = false;
            bool right = false;

            if (head.left != null && head.left.value < head.value)
                left = isValidSearchTree(head.left);
            
            if (head.right != null && head.right.value > head.value)
                right = isValidSearchTree(head.right);

            return right && left;

        }
        //    5

        //  2         7

        // 1   3     6   4

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
            node3.left = node6;
            node3.right = node7;

           
            Console.Write(isValidSearchTree(node1));
        }
    }
}

