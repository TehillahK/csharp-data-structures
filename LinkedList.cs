using System.Dynamic;

class LinkedList
{
    private Node? top;

    public LinkedList(){
        this.top = null;
    }

    public int insert(int data){
        return -1;
    }

    class Node
    {
        private int data;
        private Node? next;

        public Node(){
            
        }

        public int Data{
            get {return data;}
            set {data = value;}
        }
        
    }
}