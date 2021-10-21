using System;
using System.Collections;
using System.Collections.Generic;

namespace Arraylist_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(5.6);
            //arrayList.Add("sdfs");
            //arrayList.Clear();
            //arrayList.Add(10);
            //arrayList.Remove(10);
            //arrayList.RemoveAt(0);
            //arrayList.RemoveRange(1, 2);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numbers = new List<int>();
            MyList<int> members = new MyList<int>();
            members.AddItem(1);
            members.AddItem(1);
            members.AddItem(1);
            members.AddItem(1);
            foreach (int item in members)
            {
                Console.WriteLine(item);
            }
        }
    }

}
