using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();

            //bt.AddNode("18", 18);
            //bt.AddNode("7", 7);
            //bt.AddNode("6", 6);
            //bt.AddNode("9", 9);
            //bt.AddNode("2", 2);
            //bt.AddNode("2", 2);
            //bt.AddNode("18", 18);

            var rand = new Random(DateTime.UtcNow.Millisecond);
            for (int i = 0; i < 100; i++)
            {

                //int randInt = (int)(rand.NextDouble() * 1000000);

                //bt.AddNode(randInt.ToString(), randInt);

                bt.AddNode("1", 1);
            }

            int a = 5;

        }
    }
}
