using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinarySTree
    {
        public Node root;
        public int height;
        public int levels;
        public BinarySTree()
        {
            height = 0;
            root = null;
        }
        public void Add(int i)
        {
            levels = 0;
            Node newNode = new Node();
            newNode.data = i;
            if (root == null)
            {
                root = newNode;
                height++;
            }
            else
            {
                Node currentNode = root;
                Node parentNode;
                while (true)
                {
                    levels++;
                    if(levels >= height)
                    {
                        height = levels + 1;
                    }
                    parentNode = currentNode;
                    if (i < currentNode.data)
                    {
                        currentNode = currentNode.left;
                        if (currentNode == null)
                        {
                            parentNode.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            parentNode.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public void SearchTree(int i)
        {
            
            levels = 0;
            if (root.data == i)
            {
                Console.WriteLine(root.data + " is the root"); ;
            }
            else
            {
                Node currentNode = root;
                Node parentNode;
                while (true)
                {
                    levels++;
                    
                    parentNode = currentNode;
                    if (i < currentNode.data)
                    {
                        currentNode = currentNode.left;
                       
                        if (currentNode == null)
                        {
                            Console.WriteLine(i + " No Valid Node");
                            break;
                        }
                        if (currentNode.data == i)
                        {
                            Console.WriteLine(currentNode.data + " is too the left of the " + parentNode.data+" and "+ levels+" levels from root") ;
                            if (currentNode.right == null && currentNode.left == null)
                            {
                                Console.WriteLine(currentNode.data + " is a Leaf Node");
                                if(parentNode.right != null)
                                {
                                    Console.WriteLine(currentNode.data + " is the sibling of " + parentNode.right.data);
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            Console.WriteLine(i + " No Valid Node");
                            break;
                        }
                        if (currentNode.data == i)
                        {
                            Console.WriteLine(currentNode.data + " is to the right of the "+ parentNode.data + " and " + levels + " levels from root");
                            if(currentNode.right == null && currentNode.left == null)
                            {
                                Console.WriteLine(currentNode.data +" is a Leaf Node" );
                                if (parentNode.left != null)
                                {
                                    Console.WriteLine(currentNode.data + " is the sibling of " + parentNode.left.data);
                                    break;
                                }
                                break;
                            }
                            break;
                        }
                    }
                }
            }
        }
        public void PrintHeight()
        {
            Console.WriteLine(height + " is the height of BTS");
        }
    }
}
