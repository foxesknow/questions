using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Q590_NaryTreePostorderTraversal
{
    public class Solution
    {
        public IList<int> Postorder(Node root) 
        {
            var results = new List<int>();
            Recurse(root, results);

            return results;
        }

        private void Recurse(Node root, List<int> accumulator)
        {
            if(root is null) return;

            if(root.children is not null)
            {
                for(int i = 0; i < root.children.Count; i++)
                {
                    Recurse(root.children[i], accumulator);
                }
            }

            accumulator.Add(root.val);
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
