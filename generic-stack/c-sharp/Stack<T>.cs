public class Stack<T> {
    private Node<T> top;

    public void Push(T data) {
        Node<T> newNode = new Node<T>(data);
        newNode.SetNext(top);
        top = newNode;
    }

    public T Pop() {
        if (top == null) throw new System.InvalidOperationException("Stack is empty");
        T data = top.GetData();
        top = top.GetNext();
        return data;
    }

    public T Peek() {
        if (top == null) throw new System.InvalidOperationException("Stack is empty");
        return top.GetData();
    }

    public bool IsEmpty() { return top == null; }
}