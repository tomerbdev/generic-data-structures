public class Stack<T> {
    private Node<T> top;

    public void push(T data) {
        Node<T> newNode = new Node<>(data);
        newNode.setNext(top);
        top = newNode;
    }

    public T pop() {
        if (top == null) throw new java.util.EmptyStackException();
        T data = top.getData();
        top = top.getNext();
        return data;
    }

    public T peek() {
        if (top == null) throw new java.util.EmptyStackException();
        return top.getData();
    }

    public boolean isEmpty() { return top == null; }
}