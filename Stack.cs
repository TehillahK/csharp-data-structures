class Stack
{
    private int[] items = new int[20];
    private int topIndex ;

    public Stack(){
        this.topIndex = -1;
    }

    public bool push(int data){
        bool result = false;
        this.items[++this.topIndex] = data;
        if(this.items[topIndex]== data)
            result = true;
        return result;
    }

    public bool pop(){
        return false;
    }

    public bool isEmpty(){
        return this.topIndex == -1;
    }

}