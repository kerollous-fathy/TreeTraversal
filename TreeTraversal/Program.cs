using TreeTraversal.Tree;

namespace TreeTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Right = new Node(3);
            tree.Root.Left.Left = new Node(4);
            tree.Root.Left.Right = new Node(5);
            tree.Root.Right.Left = new Node(6);
            tree.Root.Right.Right = new Node(7);


            Console.WriteLine("Pre-Order Traversal");
            tree.PreOrder(tree.Root);

            Console.WriteLine();

            Console.WriteLine("In-Order Traversal");
            tree.InOrder(tree.Root);

            Console.WriteLine();

            Console.WriteLine("Post-Order Traversal");
            tree.PostOrder(tree.Root);


        }
    }
}
