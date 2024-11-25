using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q116_PopulateNextRight
{
    public class Node 
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() {}

        public Node(int _val) 
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next) 
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class Solution 
    {
        public Node Connect(Node root) 
        {
            if(root is null) return null;

            var current = new List<Node>();
            var next = new List<Node>();
        
            current.Add(root);
            
            while(current.Count != 0)
            {
                for(var i = 0; i < current.Count - 1; i++)
                {
                    current[i].next = current[i + 1];

                    AddIfSet(current[i].left, next);
                    AddIfSet(current[i].right, next);
                }

                var last = current.Count - 1;
                AddIfSet(current[last].left, next);
                AddIfSet(current[last].right, next);

                current.Clear();
                (next, current) = (current, next);
            }

            return root;
        }

        private void AddIfSet(Node node, IList<Node> sequence)
        {
            if(node is not null) sequence.Add(node);
        }
    }
}
