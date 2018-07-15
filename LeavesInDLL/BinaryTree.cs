using System;
using System.Collections.Generic;
using System.Text;

namespace LeavesInDLL
{
    class BinaryTree
    {
        public Node root;
        public Node head;
        private Node previous;

        public BinaryTree() {

        }

        public BinaryTree(int element) {
            root.data = element;
            root.left = root.right = null;
        }

        public Node insertBinaryTree(int data) {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {

                Node current = root;

                while (current != null)
                {
                    if (current.data <= data)
                    {
                        if (current.right == null) {
                            current.right = new Node(data);
                            return root;
                        }
                        current = current.right;
                    }
                    else
                    {
                        if (current.left == null)
                        {
                            current.left = new Node(data);
                            return root;
                        }
                        current = current.left;
                    }
                }
                current = new Node(data);
            }
            return root;
        }

        public void getDLL(Node root) {
            root = extractLeaves(root);            
            printLeavesDLL(this.head);
        }

        private Node extractLeaves(Node root) {
            if (root == null) return null;
            if (root.left == null && root.right == null) {
                if (head == null)
                {
                    head = root;
                    previous = root;
                }
                else {
                    previous.right = root;
                    root.left = previous;
                    previous = root;
                }
                return null;
            }
            root.left = extractLeaves(root.left);
            root.right = extractLeaves(root.right);
            return root;
        }

        public void inorderTraversal(Node root) {
            if (root == null)
                Console.WriteLine("Binary Tree is null or empty!");

            inorderTraversal(root.left);
            Console.WriteLine(root.data);
            inorderTraversal(root.right);
        }

        public void printLeavesDLL(Node head) {
            if (head == null) {
                Console.WriteLine("Constructed DLL is null!");
            }
            while (head != null) {
                Console.WriteLine(head.data);
                head = head.right;
            }
        }
    }
}
