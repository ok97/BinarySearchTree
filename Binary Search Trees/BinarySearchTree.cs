using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Trees
{
    class BinarySearchTree<T> where T : IComparable<T>
    {/* UC1:- Ability to create a BST by adding 56 and then adding 30 & 70 
              - Use INode to create My Binary Node - Note the key has to extend comparable to compare
              and determine left or right node
              - First add 56 as root node so 30 will be added to left and 70 to right.
      */
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData) //Constructor
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }
        int leftCount = 0; //initilize
        int rightCount = 0;
        bool result = false;
        public void Insert(T item) //insert Method
        {
            try
            {
                T CurrentNodeValue = this.NodeData;
                if (CurrentNodeValue.CompareTo(item) > 0) //check left Tree value is > 0
                {
                    if (this.LeftTree==null) //check lefttree null
                    {
                        this.LeftTree = new BinarySearchTree<T>(item); //add
                    }else
                    {
                        this.LeftTree.Insert(item);
                    }
                }
                else
                {
                    if (this.RightTree==null) //Check Right Tree value is > 0
                    {
                        this.RightTree = new BinarySearchTree<T>(item);
                    }
                    else
                    {
                        this.RightTree.Insert(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Display() //Display Method
        {
            try
            {
                if (this.LeftTree!=null)
                {
                    this.leftCount++;
                    this.LeftTree.Display(); //Display Leftside value
                }
                Console.WriteLine(this.NodeData.ToString());
                if (this.RightTree!=null)
                {
                    this.rightCount++;
                    this.RightTree.Display(); //Display RightSide value
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Run //Class
    {
        static void Main(string[] args) //Main method
        {  /* UC1 */
            Console.WriteLine("BinarySearchTree");
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56); //Create object and pass root value of tree
            bst.Insert(30); //Add Element
            bst.Insert(70);
           
            bst.Display(); //call Display Method
            Console.WriteLine("         56        ---> Root \n");
            Console.WriteLine("     30     70");
               
            Console.ReadLine();
        }
    }
}
