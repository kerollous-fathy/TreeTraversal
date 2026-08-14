using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeTraversal.Tree;

namespace TreeExample.Tree
{
    public class AVLTree
    {
        public Node Root { get; set; }


        public AVLTree()
        {
            Root = null;
        }


        public Node AVLInsert(Node? node, int key)
        {
            int balance = 0;
            if (node == null)
            {
                return new Node(key);
            }
            if (key <= node.Item)
                node.Left = AVLInsert(node.Left, key);
            else
                node.Right = AVLInsert(node.Right, key);

            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
            balance = GetBalance(node);
            if (balance >= -1 && balance <= 1)
                return node;
            else
            {
                if (balance > 1 && key <= node.Left.Item)
                    return LLRotation(node);
                if (balance < -1 && key > node.Right.Item)
                    return RRRotaion(node);
                if (balance > 1 && key > node.Left.Item)
                    return LRRotation(node);
                if (balance < -1 && key <= node.Right.Item)
                    return RLRotation(node);
            }
            return node;

        }

        public void PrintInOrder(Node? node)
        {
            if (node == null) return;
            else
            {
                PrintInOrder(node.Left);
                Console.WriteLine(node.Item);
                PrintInOrder(node.Right);
            }
        }

        private int GetBalance(Node? node) //h(l.Subtree) - h(R.Subtree) ==> {-1 , 0 , 1}
        {
            if (node == null) return 0;
            int HLSubtree = GetHeight(node.Left);
            int HRSubtree = GetHeight(node.Right);
            return HLSubtree - HRSubtree;
        }

        private int GetHeight(Node? node)
        {
            if (node == null) return 0;
            return node.Height;
        }

        private Node LLRotation(Node? node)
        {
            Node x = node.Left;
            Node BR = x.Right;

            x.Right = node;
            node.Left = BR;

            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x;
        }

        private Node RRRotaion(Node? node)
        {
            Node x = node.Right;
            Node BR = x.Left;

            x.Left = node;
            node.Right = BR;

            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x;
        }

        private Node LRRotation(Node? node)
        {
            node.Left = RRRotaion(node.Left);

            return LLRotation(node);
        }

        private Node RLRotation(Node? node)
        {
            node.Right = LLRotation(node.Right);
            return RRRotaion(node);
        }
    }
}
