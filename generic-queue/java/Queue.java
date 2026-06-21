public class Queue<T> {
    private Node<T> front, rear;

    public void enqueue(T data) {
        Node<T> newNode = new Node<>(data);
        if (rear == null) {
            front = rear = newNode;
            return;
        }
        rear.setNext(newNode);
        rear = newNode;
    }

    public T dequeue() {
        if (front == null) throw new java.util.NoSuchElementException();
        T data = front.getData();
        front = front.getNext();
        if (front == null) rear = null;
        return data;
    }

    public boolean isEmpty() { return front == null; }
}