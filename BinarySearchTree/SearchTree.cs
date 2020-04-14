using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class SearchTree
    {
        public Node root = null;
        public void Add(Node leftChild, Node rightChild, int data )
        {
            //root = null;
            Node node = new Node();
            node.data = data;

            if (root == null)
            {
                root = new Node();
                root.data = data;
            }
            else if (root.data > data)
            {
                root.rightChild = new node (root.rightChild, data);
            }
        }
    }
}

    

