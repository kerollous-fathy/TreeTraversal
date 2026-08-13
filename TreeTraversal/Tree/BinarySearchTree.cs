using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TreeTraversal.Tree;

namespace TreeExample.Tree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(Node node)
        {
            if (Root == null)
            {
                Root = node;
                return;
            }
            Node curr = Root;
            Node parent = null;
            while (curr != null)
            {
                parent = curr;
                if (node.Item <= curr.Item)
                {
                    curr = curr.Left;
                }
                else
                    curr = curr.Right;
            }
            if (node.Item <= parent.Item)
                parent.Left = node;
            else
                parent.Right = node;
        }


        public bool Search(int key)
        {
            Node curr = Root;
            while (curr != null)
            {
                if (key == curr.Item)
                    return true;
                if (key < curr.Item)
                    curr = curr.Left;
                else
                    curr = curr.Right;
            }
            return false;
        }

        public void Delete(int key)
        {
            Root = DeleteNode(Root , key);
        }

        private Node DeleteNode(Node root, int key)
        {
            if (root == null)
                return root;
            if(key < root.Item)
            {
                root.Left = DeleteNode(root.Left, key);
            }
            else if(key > root.Item)
            {
                root.Right = DeleteNode(root.Right, key);
            }
            else
            {
                if (root.Left == null && root.Right == null)
                    return null;
                else if (root.Left == null)
                    return root.Right;
                else if(root.Right == null)
                    return root.Left;
                else
                {
                    Node successor = GetMinValue(root.Right);
                    root.Item = successor.Item;
                    root.Right = DeleteNode(root.Right, successor.Item);
                }
            }
            return root;
        }

        public Node GetMinValue(Node node)
        {
            while(node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        public void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Item + " ");
            InOrder(node.Right);
        }
    }
}
