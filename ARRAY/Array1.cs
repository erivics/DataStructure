namespace DATASTRUCTURE.ARRAY;

public class Array1
{
    private int[] items;
    private int count;
 public Array1(int lenght)
 {
     items = new int[lenght];
 }

 public void insert(int item)
 {
     //if the item is full resize it
     if(items.Length == count)
     {
         int[] newItems = new int[count * 2];
         for (int i = 0; i < count; i++)
         newItems[i] =  items[i];

         items = newItems;
     }
     
     items[count] = item;
     count++;
 }

 public void removeAt(int index)
 {
     if (index < 0 || index >= count)
     {
         throw new ArgumentOutOfRangeException();
     }
     for(int i = index; i < count; i++)
     items[i] = items[i + 1];

     count--;

 }

 public int indexOf(int item)
 {
     for(int i = 0; i < count; i++)
     if(items[i] == item)
     {
         return i;
     }
     return -1;
 }

public void Print()
{
    for(int i = 0; i < count; i++)
    Console.WriteLine(items[i]);
}


}