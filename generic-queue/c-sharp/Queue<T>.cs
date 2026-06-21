public class Queue<T> {
    private Node<T> front, rear;

    public void Enqueue(T data) {
        Node<T> newNode = new Node<T>(data);
        if (rear == null) {
            front = rear = newNode;
            return;
        }
        rear.SetNext(newNode);
        rear = newNode;
    }

    public T Dequeue() {
        if (front == null) throw new System.InvalidOperationException("Queue is empty");
        T data = front.GetData();
        front = front.GetNext();
        if (front == null) rear = null;
        return data;
    }

    public bool IsEmpty() { return front == null; }
}