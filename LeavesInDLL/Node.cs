using System;
using System.Collections.Generic;
using System.Text;

namespace LeavesInDLL
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int element) {
            data = element;
            left = right = null;
        }
    }
}
