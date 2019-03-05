using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    class Stack<T>
    {
        private T[] data = new T[10];
        private int top = 0;

        public void Push(T v)
        {
            data[top] = v;
            top++;
        }

        public T Pop()
        {
            top--;
            return data[top];
        }
    }

    static class ExtClass
    {
        public static string GetAuthor(this Stack<string>  s)
        {
             return "Srikanth Pragada";
        }
    }
    public class TestStack
    {

        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            

            Console.WriteLine(s.Pop());

            Stack<string> s2 = new Stack<string>();
            s2.Push("Abc");
            s2.Push("Xyz");
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.GetAuthor());

       }
    }
}
