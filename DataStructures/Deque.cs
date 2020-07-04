
using System.Collections.Generic;
using System.Text;
using System;

namespace DataStructures
{
    class Deque<E>
    {
        private  List<E> elements;

        // constructor
        public Deque() => elements = new List<E>();
        
        
        // modification related
        public void Clear() => elements.Clear();
        public void PushBack(E elem) => elements.Add(elem);
        public void PushFront(E elem) => elements.Insert(0, elem);
        public void PopBack() => elements.RemoveAt(elements.Count-1);
        public void PopFront() => elements.RemoveAt(0);


        // access related
        public E Front() => elements[0]; 
        public E Back() => elements[^1]; 

        // condition related
        public int Size() => elements.Count; 
        public bool Empty() => Size() == 0; 

        //overriden from object
        public override string ToString()
        {
            if (Empty())
                return "EMPTY DEQUE\n";
            
            StringBuilder sb = new StringBuilder();
            sb.Append("FRONT-> ").Append(Front().ToString()).Append(" ");
            for (int i = 1; i <elements.Count-1; i++)
                sb.Append(elements[i].ToString()).Append(" ");
            sb.Append(Back().ToString()).Append(" <-BACK\n");

            return sb.ToString();
        }

        //destructor
        ~Deque() => elements = null;
    }
}
