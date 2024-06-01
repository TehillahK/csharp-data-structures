

class LinkedList
{
    private Node? top;

    public LinkedList(){
        this.top = null;
    }

    public int insert(int data){
        int result = -1;
        if(top == null){
            top = new Node(data);
            result = top.Data;
        }else{
            Node newNode = new Node(data);
            Node? currNode = top;
            while(currNode.Next != null){
                currNode = currNode.Next;
            }
            currNode.Next = newNode;
            result = currNode.Next.Data;

        }
        return result;
    }

    class Node
    {
        private int data;
        private Node? next;

        public Node(int data){
            this.data = data;
            this.next = null;
        }

        public int Data{
            get {return data;}
            set {data = value;}
        }
        
        public Node Next{
            get {return next;}
            set {next = value;}
        }
    }
}