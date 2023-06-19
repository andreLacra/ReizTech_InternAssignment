using System;

namespace problem2
{

    public class Node
    {
        public int data;
        public Node left, middle, right;

        public Node(int item)
        {
            data = item;
            left = middle = right = null;
        }
    }
    class Branch
    {
        Node root;

        public int depth(Node node)
        {
            if (node == null)  // will return 0 if tree is empty
            {
                return 0;
            }
            else
            {
                int leftDepth = depth(node.left);
                int middletDepth = depth(node.middle);
                int rightDepth = depth(node.right);

                if ((leftDepth > rightDepth) && (leftDepth > middletDepth))
                {
                    return (leftDepth + 1);
                }
                if ((rightDepth > leftDepth) && (rightDepth > middletDepth))
                {
                    return (rightDepth + 1);
                }
                else
                {
                    return (middletDepth + 1);
                }
            }
        }

        static void Main(string[] args)
        {
            Branch structure = new Branch();

            // root
            structure.root = new Node(1);

            // right branch
            structure.root.left = new Node(2);
            structure.root.left.left = new Node(3);

            // left branch
            structure.root.right = new Node(4);
            structure.root.right.left = new Node(5);
            structure.root.right.middle = new Node(6);
            structure.root.right.right = new Node(7);
            structure.root.right.left.left = new Node(8);
            structure.root.right.middle.left = new Node(9);
            structure.root.right.middle.left.left = new Node(10);
            structure.root.right.middle.right = new Node(11);

            Console.WriteLine("\n===========\nDepth: {0}\n===========", structure.depth(structure.root));

        }
    }
}