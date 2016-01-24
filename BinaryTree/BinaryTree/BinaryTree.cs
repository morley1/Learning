using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {

        int nodesCount;

        TreeNode Root;
        public BinaryTree()
        {
            Root = null;
            nodesCount = 0;
        }

        public TreeNode AddNode(string name, int value)
        {
            TreeNode node = new TreeNode(name, value);

            if (Root == null)
            {
                Root = node;
                nodesCount++;
            }
            else
            {
                Insert(node, ref Root);
            }
            
            return node;
        }

        private void Insert(TreeNode node, ref TreeNode tree)
        {
            if (tree == null)
            {
                tree = node;
                nodesCount++;
            }
            else
            {
                if(node.NodeValue < tree.NodeValue)
                {
                    Insert(node, ref tree.LeftNode);
                }
                else if (node.NodeValue > tree.NodeValue)
                {
                    Insert(node, ref tree.RightNode);
                }
            }
        }

    }
}
