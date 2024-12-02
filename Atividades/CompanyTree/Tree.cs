using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyStructure
{
    public class Tree<T>
    {
        public TreeNode<T>? Root { get; set; }

        public void PrintTree(TreeNode<Person> node, int level = 0)
        {
            Console.WriteLine(new string(' ', level * 2) + $"Level: {level}, Node: {node.Data?.Name}, Role: {node.Data?.Role}");

            if (node.Children != null)
            {
                foreach (var child in node.Children)
                {
                    PrintTree(child, level + 1);
                }
            }
        }
    }
    public class TreeNode<T>
    {
        public T? Data { get; set; }
        public TreeNode<T>? Parent { get; set; }
        public List<TreeNode<T>>? Children { get; set; } = new List<TreeNode<T>>();
    }
}