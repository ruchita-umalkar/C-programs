// Program to demonstrate indexers  
using System;
class MyCollection
{
    private int[] arr = new int[100];

    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }
}
    