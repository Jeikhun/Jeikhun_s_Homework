using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> lift = new MyStack<string>();
            lift.Push("Ceyhun");
            lift.Push("Magsud");
            lift.Push("Nicat");
            lift.Pop();
            Console.WriteLine(lift.Peek());
            
        }
    }

    class MyStack<T> : IEnumerable
    {

        private T[] _value;
        public int Count { get; set; }
        public int Capacity { get; set; }

        public void Push(T value)
        {
            Capacity = 4;
            _value = new T[Capacity];
            if(Capacity == Count)
            {
                Capacity = Capacity * 2;
                Array.Resize(ref _value, Capacity);                
            }
            _value[Count] = value;
            Count++;           
        }
        public T Peek()
        {
            T temp = default(T);
            
            for(int i=_value.Length-1; i>=0 ; i--)
            {
                temp = _value[i];
                break ;
            }return temp;
        }
        public T Pop()
        {
            T temp = default(T);
            for(int i=0; i<Count; i++)
            {
                temp = _value[Count-1];
                Count--;
            }return temp;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i=_value.Length-1; i>=0 ; i--)
            {
                yield return _value[i];
            }
        }
    }
}
