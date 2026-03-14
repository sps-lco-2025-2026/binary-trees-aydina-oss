using System;
using System.Collections.Generic;
using System.Diagnostics;

class TestBinaryTree
{
    static void Main()
    {  BinaryTree tree = new BinaryTree();
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);
        tree.Insert(3);
        tree.Insert(7);
        tree.Insert(12);
        tree.Insert(20);

        string expectedInOrder = "3 5 7 10 12 15 20";
        string actualInOrder = tree.ToString();
        Debug.Assert(actualInOrder.Equals(expectedInOrder));

        Debug.Assert(tree.Present(7) == true);
        Debug.Assert(tree.Present(9) == false);
        Debug.Assert(tree.Present(20) == true);

        Debug.Assert(tree.Sum() == 89);

        Debug.Assert(tree.Depth() == 4);

        Debug.Assert(tree.IsBalanced() == true);


    }

}