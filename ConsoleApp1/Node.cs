internal class Node
{
    public int Value;
    public Node left;
    public Node right;

    public Node(int value)
    {
        Value = value;
        left = null;
        right = null;
    }
    public void Insert(int value)
    {
        if(value < Value)
        {
            if(left == null)
            {
                left = new Node(value);
            }
            else
            {
                left.Insert(value);
            }
        }
        else
        {
            if(right == null)
            {
                right = new Node(value);
            }
            else
            {
                right.Insert(value);
            }
        }
    }
    public bool Present(int value)
    {
        if(value == Value)
            {
                return true;
            }
        else if (value<Value)
        {
            if (left == null)
            {
                return false;
            }
            return left.Present(value); 
            
        }
        else
        {
            if (right == null)
            {
                return false;
            }
            return right.Present(value); 
        } 

    }
    public int Sum()
    {
        int sum = Value;
        if(left != null)
        {
            sum+=left.Sum();
        }
        if(right != null)
        {
            sum+=right.Sum();
        }
        return sum;
    }
    public void InOrder(List<int> values)
    {
        if (left != null)
        {
            left.InOrder(values);
        }

        values.Add(Value);

        if (right != null)
        {
            right.InOrder(values);
        }
    }
    public int Depth()
    {
        int leftDepth = 0;
        int rightDepth=0;
        if(left != null)
        {
            leftDepth=left.Depth();
        }
        if (right != null)
        {
            rightDepth=right.Depth();
        }
        return 1 + Math.Max(leftDepth,rightDepth);
    }
    public bool IsBalanced()
    {
        int leftDepth=0;
        int rightDepth=0;
        if(left != null)
        {
             leftDepth=left.Depth();
        }
        else
        {
            leftDepth = 0; 
        }
        if(right != null)
        {
             rightDepth=right.Depth();
        }
        else
        {
            rightDepth= 0; 
        }

        bool leftBalanced = left == null || left.IsBalanced();
        bool rightBalanced = right == null || right.IsBalanced();
        return leftBalanced && rightBalanced;

    }
    






}