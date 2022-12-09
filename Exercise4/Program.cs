using System;
using System.Collections;

namespace Exercise4
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('e');
            st.Push('f');
            st.Push('g');
            Console.WriteLine("Stack = ");
            foreach (char ch in st)
            {
                Console.WriteLine(ch + " ");
            }
        }
    }
}