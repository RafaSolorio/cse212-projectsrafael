using System.Diagnostics.Tracing;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // If it's a duplicate this will not be added to the tree.
        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // Base case 
        if (value == Data)
        {
            return true;
        }

        // Search on the left
        if (value < Data)
        {
            if (Left is null)
            {
                return false; // No more nodes to the left
            }
            else
            {
                return Left.Contains(value); // Keep looking for value
            }
        }    
        // Search on the right
        else
        {
            if (Right is null)
            {
                return false; // No more nodes to the right
            }
            else
            {
                return Right.Contains(value); // Keep looking for value
            }
        }

    }

    public int GetHeight()
    {
        // Height counters 
        int leftBranch = 0;
        int rightBranch = 0;

        // Calculate height of left branch if it exists
        if (Left != null)
        {
            leftBranch = Left.GetHeight();
        }
 
        // Calculate height of right branch if it exists
        if (Right != null)
        {
            rightBranch = Right.GetHeight();
        }

        // Compare branches to get the height
        if (leftBranch > rightBranch)
        {
            return leftBranch + 1;
        }
        else
        {
            return rightBranch + 1;
        }
        
    }
}