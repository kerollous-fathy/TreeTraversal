using TreeExample.Tree;
using TreeTraversal.Tree;

namespace TreeTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BinaryTree tree = new BinaryTree();
            //tree.Root = new Node(1);
            //tree.Root.Left = new Node(2);
            //tree.Root.Right = new Node(3);
            //tree.Root.Left.Left = new Node(4);
            //tree.Root.Left.Right = new Node(5);
            //tree.Root.Right.Left = new Node(6);
            //tree.Root.Right.Right = new Node(7);


            //Console.WriteLine("Pre-Order Traversal");
            //tree.PreOrder(tree.Root);

            //Console.WriteLine();

            //Console.WriteLine("In-Order Traversal");
            //tree.InOrder(tree.Root);

            //Console.WriteLine();

            //Console.WriteLine("Post-Order Traversal");
            //tree.PostOrder(tree.Root);

            //Console.WriteLine();

            //Console.WriteLine("Level Order Traversal");
            //tree.LevelOrder(tree.Root);


            BinarySearchTree bst = new BinarySearchTree();
            Node Root = new Node(20);
            bst.Insert(Root);
            bst.Insert(new Node(10));
            bst.Insert(new Node(30));
            bst.Insert(new Node(25));
            bst.Insert(new Node(35));

            Console.WriteLine("--- (In-Order) ---");
            bst.InOrder(bst.Root);
            Console.WriteLine("\n");

            bst.Delete(20);

            Console.WriteLine("--- after delete node 20 ---");
            bst.InOrder(bst.Root);
            Console.WriteLine("\n");

            Console.WriteLine("Is number 20 exist? " + bst.Search(20)); 
            Console.WriteLine("Is number 25 exist? " + bst.Search(25));
        }
    }
}
