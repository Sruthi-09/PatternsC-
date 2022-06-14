using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Abc
    {
        int[] data;
        int rear;
        int front;
        public Abc() : this(10) { }
        public Abc(int size)
        {
            data = new int[size];
        }
        public void enqueue(int num)
        {
            if (rear == data.Length)
            {
                Console.WriteLine("Queue is full");
            }
            data[rear++] = num;
        }
        internal int  dequeue()
        {
            if (front == rear+1)
            {
                Console.WriteLine("Queue is empty");
            }
            return data[front++];
        }
        public bool isFull()
        {
            return rear == data.Length;
        }
        public bool isEmpty()
        {
            return front == 0;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Abc abc = new Abc();
            for(int i=20;!abc.isFull(); i++)
            {
                abc.enqueue(i);
                Console.WriteLine(i);
            }
            for(int i=0;!abc.isEmpty(); i++)
            {
                Console.WriteLine(abc.dequeue());
            }
            abc.enqueue(30);
            Console.WriteLine(abc);
            
        }
    }
}
