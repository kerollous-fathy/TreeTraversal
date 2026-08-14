# 🌳 Tree Data Structures in C# (.NET 9)

A comprehensive implementation of hierarchical tree data structures built from scratch in C#, covering **General Binary Trees**, **Binary Search Trees (BST)**, and **Self-Balancing AVL Trees**.

---

## 📌 Table of Contents
1. [Overview & Motivation](#-overview--motivation)
2. [Project Architecture](#-project-architecture)
3. [Core Concepts & Progression](#-core-concepts--progression)
4. [Complexity Analysis](#-complexity-analysis)
5. [Quick Demo & Verification](#-quick-demo--verification)

---

## 💡 Overview & Motivation

Tree data structures are fundamental for organizing hierarchical data and providing efficient search, insertion, and deletion operations.

This repository demonstrates the evolution from an unbalanced tree to an optimized self-balancing AVL tree:
* **Binary Tree:** Foundations of hierarchical nodes and traversal algorithms.
* **BST:** Enforcing ordering rules for fast average lookups.
* **AVL Tree:** Preventing tree skewing/degeneration into $O(n)$ linked lists via dynamic balancing and rotations.

---

## 🏗️ Project Architecture

```text
TreeExample/
│
├── Tree/
│   ├── Node.cs                 # Base Node structure (Item, Left, Right, Height)
│   ├── BinaryTree.cs           # Tree Traversals (In-Order, Pre-Order, Post-Order)
│   ├── BinarySearchTree.cs     # BST Insertion, Search & Duplicate Handling
│   └── AVLTree.cs              # Self-Balancing logic (LL, RR, LR, RL Rotations)
│
└── Program.cs                  # Test Harness & Console Demos
```
---

## 💡 Core Concepts & Progression

### 1. General Binary Tree (`BinaryTree.cs`)
* Serves as the foundation of hierarchical structures with a `Root` property.
* Implements both **Depth-First Search (DFS)** and **Breadth-First Search (BFS)** traversals:
  * **DFS:** `InOrder` (Left $\rightarrow$ Root $\rightarrow$ Right), `PreOrder` (Root $\rightarrow$ Left $\rightarrow$ Right), and `PostOrder` (Left $\rightarrow$ Right $\rightarrow$ Root).
  * **BFS:** `LevelOrder` traversal to visit nodes level-by-level using a Queue.

### 2. Binary Search Tree (`BinarySearchTree.cs`)
* Enforces ordered subtrees ($\text{Left} \le \text{Node} < \text{Right}$) to achieve $O(\log n)$ average lookup.
* **The Problem:** In sorted or semi-sorted insertions, BST degenerates into an $O(n)$ linked list (Skewed Tree).

### 3. Self-Balancing AVL Tree (`AVLTree.cs`)
* Automatically maintains an optimal tree height ($O(\log n)$ guaranteed).
* Tracks the **Balance Factor**:
  $$\text{Balance Factor} = \text{Height}(\text{Left}) - \text{Height}(\text{Right})$$
* Fixes imbalances dynamically during recursive backtracking using 4 rotations:
  * **Single Rotations:** `LLRotation` & `RRRotation`
  * **Double Rotations:** `LRRotation` & `RLRotation`

---

## ⏱️ Complexity Analysis

| Data Structure | Search (Avg) | Search (Worst) | Insert (Avg) | Insert (Worst) | Space Complexity |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **Binary Tree** | $O(n)$ | $O(n)$ | $O(1)$ | $O(n)$ | $O(n)$ |
| **BST (Unbalanced)** | $O(\log n)$ | $O(n)$ | $O(\log n)$ | $O(n)$ | $O(n)$ |
| **AVL Tree (Balanced)**| $\mathbf{O(\log n)}$ | $\mathbf{O(\log n)}$ | $\mathbf{O(\log n)}$ | $\mathbf{O(\log n)}$ | $O(n)$ |

---

## 🚀 Quick Demo & Verification

### Driver Code (`Program.cs`)

```csharp
AVLTree avl = new AVLTree();
Node Root = null;

int[] values = new int[] { 40, 20, 10, 25, 30, 22, 50 };
foreach (int value in values)
{
  Console.WriteLine($"Inserting value {value}");
  Root = avl.AVLInsert(Root, value);
}
Console.WriteLine("Print In-Order Traversal");
avl.PrintInOrder(Root);

Console.WriteLine($"\nRoot Node is: {Root?.Item}");
Console.WriteLine($"Total Tree Height is: {Root?.Height}");
```
