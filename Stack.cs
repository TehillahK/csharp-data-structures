class Stack
{
    private int[] items = new int[20];
    private int topIndex ;

    public Stack(){
        this.topIndex = -1;
    }

    public int push(int data){
        int result = -1;
        this.items[++this.topIndex] = data;
        if(this.items[topIndex]== data)
            result = this.items[topIndex];
        return result;
    }

    public int pop(){
        if(this.topIndex>-1)
            return this.items[this.topIndex--];
        else{
            return -1;
        }
    }

    public bool isEmpty(){
        return this.topIndex == -1;
    }

}