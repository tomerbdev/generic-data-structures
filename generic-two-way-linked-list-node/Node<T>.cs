public class Node<T>
{
    // Fields
    private T data;
    private Node<T> next;
    private Node<T> prev;

    // Constructors
    public Node(T data)
    {
        this.data = data;
        this.next = null;
        this.prev = null;
    }

    public Node(T data, Node<T> next, Node<T> prev)
    {
        this.data = data;
        this.next = next;
        this.prev = prev;
    }

    // Getters and Setters
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

    public Node<T> GetPrev()
    {
        return prev;
    }

    public void SetPrev(Node<T> prev)
    {
        this.prev = prev;
    }
}