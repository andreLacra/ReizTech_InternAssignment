using System;

namespace problem2
{
    public class Node
    {
        public char data;
        public Node left, middle, right;

        public Node(char item)
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
            if (node == null)  // will return 0 if node is empty
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
            structure.root = new Node('a');

            // left branch
            structure.root.left = new Node('a');
            structure.root.left.left = new Node('c');

            // right branch
            structure.root.right = new Node('d');
            structure.root.right.left = new Node('e');
            structure.root.right.middle = new Node('f');
            structure.root.right.right = new Node('g');
            structure.root.right.left.left = new Node('h');
            structure.root.right.middle.left = new Node('i');
            structure.root.right.middle.left.left = new Node('j');
            structure.root.right.middle.right = new Node('k');

            Console.WriteLine("\n===========\nDepth: {0}\n===========", structure.depth(structure.root));

        }
    }
}