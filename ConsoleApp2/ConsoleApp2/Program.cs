using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {            
            MyList<int> intlist = new MyList<int>();
            intlist.AddItem(10);
            intlist.AddItem(12);
            intlist.AddItem(3);
            intlist.AddItem(4);

            intlist.Uptadeitem(2,5);            
            intlist.RemoveItem();
            intlist.ShowItems();

        }
    }
}
