public class BinaryTree
{
    private Node root;

    public void Insert(int value)
    {
        if(root == null)
        {
            root = new Node(value);
        }
        else
        {
            root.Insert(value);
        }
    }
    public bool Present(int value)
    {
        if(root == null)
        {
            return false;
        }
        else
        {
            return root.Present(value);
        }
    }
    public int Sum()
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            return root.Sum();
        }
    }
    public override string ToString()
    {
        List<int> values = new List<int>();

        if (root != null)
        {
            root.InOrder(values);
        }

        return string.Join(" ", values);
    }
    public int Depth()
    {
        if (root == null)
        {
            return 0;
        }
        return root.Depth();
    }
    public bool IsBalanced()
    {
    if (root == null)
        return true;

    return root.IsBalanced();
    }


}