using System;
using System.Text;
using System.Collections.Generic;

namespace linked_list
{
    class Program
    {

        private Nodo first;
        private int size;

        public Program(){
            this.first = null;
            this.size = 0;
        }

        public void EmptyList(){
            if(first == null){
                Console.WriteLine("This is an Empty List");
            }else{
                Console.WriteLine("This is has elements");
            }
        }

        public void addNodo(int data){
            Nodo newNodo = new Nodo(data);
            newNodo.next = first;
            first = newNodo;
            size++;
        }

        public void PrintList(){
            Nodo actual = first;
            while(actual != null){
                Console.Write("[" + actual.data + "]->");
                actual = actual.next;
            }
        }

        public int SizeList(){
            return size;
        }


        static void Main(string[] args)
        {
            Program list = new Program();
            list.EmptyList();
            list.addNodo(1);
            list.addNodo(2);
            list.addNodo(3);
            list.addNodo(4);
            list.addNodo(5);
            list.PrintList();
            Console.WriteLine();
            Console.WriteLine("Size list = " + + list.SizeList());
            list.EmptyList();
            Console.ReadLine();

        }

        
    }
}
