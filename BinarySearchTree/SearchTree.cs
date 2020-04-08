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
        Node root;
      

        public SearchTree()
        {
            root = null;
            Node node;
        }

        public void Add(int data)
        {
            Node newNode = new Node();

            if (root == null)
            {
                root = newNode;
            }

            
        }

        public void Bool (int data)
        {
            SearchTree searchTree = new SearchTree();

            searchTree.Add(8);
            searchTree.root.leftChild.Add(4);
            searchTree.root.leftChild.Add(6);
            searchTree.root.leftChild.Add(10);
            searchTree.root.leftChild.Add(12);
            searchTree.root.rightChild.Add(15);
            searchTree.root.rightChild.Add(20);
            searchTree.root.rightChild.Add(30);
            searchTree.root.rightChild.Add(40);

            if ()
            {

            }



            

            
             
            
           
            

            
        }


        

        
        

        
        

       
        
           
        



    }

    
}
