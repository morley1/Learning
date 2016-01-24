using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode
    {
        public int NodeValue { get; set; }

        public  string NodeName { get; set; }

        public TreeNode LeftNode;

        public TreeNode RightNode;

        public  TreeNode(string name, int value)
        {
            LeftNode = null;
            RightNode = null;
            NodeValue = value;
            NodeName = name;
        }
    }
}
