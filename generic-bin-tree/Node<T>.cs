public class Node<T> {
    private T data;
    private Node<T> left;
    private Node<T> right;

    public Node(T data) {
        this.data = data;
        this.left = null;
        this.right = null;
    }

    public Node(T data, Node<T> left, Node<T> right) {
        this.data = data;
        this.left = left;
        this.right = right;
    }

    // Getters and Setters
    public T GetData() {
        return data;
    }
    public void SetData(T data) {
        this.data = data;
    }

    public Node<T> GetLeft() {
        return left;
    }

    public void SetLeft(Node<T> left) {
        this.left = left;
    }

    public Node<T> GetRight() {
        return right;
    }

    public void SetRight(Node<T> right) {
        this.right = right;
    }
}