using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public class Node
        {
            public object Element;
            public Node Link;
              
            public Node() // Boş Node
            {
                Element =null;
                Link = null;
            }
            public Node(object theElement)
            { // Bir nodun tanımlanması
                Element = theElement;
                Link = null;
            }

        }

        public class LinkedList
        {
            protected Node header;
          
            public LinkedList()
            {
                header = new Node("header");
            }
            private Node Find(Object item)
            {
                Node current = new Node();
                current = header;
                while (current.Element != item)
               current = current.Link;
                return current;
            }
        public Node SonElEmanBul()
        {
            Node Curent = new Node();
            Curent = header;
            while(Curent.Link!=null)
            {
                Curent = Curent.Link;
            }
            return Curent;
        }

            //Arkadan Ekleme 
            public void Insert(Object newItem)
                 {
             Node Soneleman = new Node();
            Soneleman = SonElEmanBul();
            Node Toadd = new Node();
            Toadd.Element = newItem;
            Soneleman.Link = Toadd;
                  }
           public void PrintList()
            {
           Node MyNode = new Node();
            MyNode = Header;
            while(MyNode.Link!=null)
            {
                Console.WriteLine(MyNode.Data);
                MyNode = MyNode.Link;
            }
            }
       //Ön'den Ekleme 
         public void AddFirst(Object data)
            {
                Node toAdd = new Node();

                toAdd.Element = data;
                toAdd.Link = header;

                header = toAdd;
            }
            //Önceki Bulma
            private Node FindPrevious(Object n)
            {
                Node current = header;
                while (!(current.Link == null) && (current.Link.
                Element != n))
                    current = current.Link;
                return current;
            }
            //Silme
            public void Remove(Object n)
            {
            Node p = FindPrevious(n);
            if (!(p.Link == null))
             p.Link = p.Link.Link;
            }

    }
        static void Main(string[] args)
        {
           
            LinkedList mylist = new LinkedList();
           
           //add My First Data 
            mylist.AddFirst("ali");
            mylist.AddFirst("Rağib");
            mylist.AddFirst("Aydın");
            mylist.AddFirst("yahya");
            mylist.AddFirst("mustafa");

            mylist.Insert("ahmed", "ali");
            //No we Can add new items in here



            mylist.PrintList();
            Console.ReadLine();
         

        }
    }
}
