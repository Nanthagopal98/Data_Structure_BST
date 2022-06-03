using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class BSTFunctions<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BSTFunctions<T> LeftTree { get; set; }
        public BSTFunctions<T> RightTree { get; set; }
        public BSTFunctions(T Node)
        {
            this.NodeData = Node;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BSTFunctions<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BSTFunctions<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                rightCount++;
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, BSTFunctions<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Element Found in BST " + node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;

        }
    }
}
