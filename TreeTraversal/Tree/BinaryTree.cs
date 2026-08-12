using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal.Tree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }
        // Pre-Order (root - left - right)
        public void PreOrder(Node node)
        {
            if(node != null)
            {
                Console.Write(node.Item + " ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        //In-Order (left - root - right)
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Item + " ");
                InOrder(node.Right);
            }
        }

        //Post-Order (left - right - root)
        public void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Item + " ");
            }
        }


        //Breadth-First Traversal
        public void LevelOrder(Node root)
        {
            if (root == null)
                return;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                Node curr = (Node)queue.Peek();
                Console.Write(curr.Item + " ");
                if(curr.Left != null)
                    queue.Enqueue(curr.Left);
                if(curr.Right != null)
                    queue.Enqueue(curr.Right);
                queue.Dequeue();
            }
        }
    }
}
