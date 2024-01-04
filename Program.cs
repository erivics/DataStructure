using System.Collections.Generic;
using DATASTRUCTURE.ARRAY;
using DATASTRUCTURE.LINKEDLIST;

public class Program
{
  static void Main(string[] arg)
    {
        // Array1 numbers = new Array1(3);
        // numbers.insert(10);
        // numbers.insert(20);
        // numbers.insert(30);
        // numbers.insert(40);
        // Console.WriteLine(numbers.indexOf(100));
        // numbers.Print();
        //var list =  new ArrayList();
        // var list2 =  new ArrayList(){"Ade", "is"};
        // list.Add(20);
        // list.Add(30);
        // list.Add(40);
        // list.Insert(2, "Kola");
        // list.InsertRange(1 , list2);
        // foreach(var mylist in list)
        // {
        //     Console.WriteLine("Print the value :" + mylist);
        // }
        // Console.WriteLine(list.Contains("kola"));

        var simpleLinkedList = new SimpleLinkedList();
        simpleLinkedList.AddLast(40);
        simpleLinkedList.AddLast(35);
        simpleLinkedList.AddLast(15);
        simpleLinkedList.AddLast(30);
        simpleLinkedList.AddFirst(10);
        
        //simpleLinkedList.removeLast();
        simpleLinkedList.ReadAll();
        //Console.WriteLine(simpleLinkedList.IndexOf(35));
        //Console.WriteLine(simpleLinkedList.Contains(55));
    }

      
        
}

    
