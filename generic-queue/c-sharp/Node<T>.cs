public class Node<T>
{
    //fields
    private T data;
    private Node<T> next;

    //Constructors
    public Node(T data)
    {
        this.data = data;
        this.next = null;
    }

    public Node(T data, Node<T> next)
    {
        this.data = data;
        this.next = next;
    }
    
    //Getters and Setters
    public T GetData()
    {
        return data;
    }

    public void SetData(T data)
    {
        this.data = data;
    }

    public Node<T> GetNext()
    {
        return next;
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }
}