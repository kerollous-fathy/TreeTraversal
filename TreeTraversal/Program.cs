using TreeExample.Tree;
using TreeTraversal.Tree;

namespace TreeTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Binary Tree
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
            #endregion


            #region Binary Search Tree
            //BinarySearchTree bst = new BinarySearchTree();
            //Node Root = new Node(20);
            //bst.Insert(Root);
            //bst.Insert(new Node(10));
            //bst.Insert(new Node(30));
            //bst.Insert(new Node(25));
            //bst.Insert(new Node(35));

            //Console.WriteLine("--- (In-Order) ---");
            //bst.InOrder(bst.Root);
            //Console.WriteLine("\n");

            //bst.Delete(20);

            //Console.WriteLine("--- after delete node 20 ---");
            //bst.InOrder(bst.Root);
            //Console.WriteLine("\n");

            //Console.WriteLine("Is number 20 exist? " + bst.Search(20));
            //Console.WriteLine("Is number 25 exist? " + bst.Search(25)); 
            #endregion

            #region AVL Tree
            //AVLTree avl = new AVLTree();
            //Node Root = null;

            //int[] values = new int[] { 40, 20, 10, 25, 30, 22, 50 };
            //foreach (int value in values)
            //{
            //    Console.WriteLine($"Inserting value {value}");
            //    Root = avl.AVLInsert(Root, value);
            //}

            //Console.WriteLine("Print In-Order Traversal");
            //avl.PrintInOrder(Root);

            //Console.WriteLine($"\nRoot Node is: {Root?.Item}");
            //Console.WriteLine($"Total Tree Height is: {Root?.Height}"); 
            #endregion
        }
    }
}
