using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySTree bTs = new BinarySTree();
            bTs.Add(10);
            bTs.Add(40);
            bTs.Add(5);
            bTs.Add(20);
            bTs.Add(35);
            bTs.Add(50);
            bTs.Add(1);
            bTs.SearchTree(10);
            bTs.SearchTree(40);
            bTs.SearchTree(20);
            bTs.SearchTree(35);
            bTs.SearchTree(50);
            bTs.SearchTree(1);
            bTs.SearchTree(5);
            bTs.SearchTree(100);
            bTs.PrintHeight();
            Console.ReadLine();
            
        }
    }
}
