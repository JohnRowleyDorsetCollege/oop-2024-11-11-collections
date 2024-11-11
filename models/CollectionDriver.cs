using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_11_11_collections.models
{
    public static  class CollectionDriver
    {
        public static void Run()
        {
            StackDemo();
            string message = "Now is the winter of our discontent";
            string reversedString = ReverseString(message);
            Console.WriteLine(ReverseString(reversedString).ToLower());
        }
        public static void StackDemo()
        {
            // in this case, this is a stack of integers
            // your stack can hold any type
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }

            //Peek at the top element
            Console.WriteLine($"Top Element (Peek) : {stack.Peek()}");

            Console.WriteLine($"Popped element: {stack.Pop()}");

            Console.WriteLine($"Stack after popping an element:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            bool exists = stack.Contains(10);

            if (exists)
            {
                Console.WriteLine("Stack contains 10");
            }

            Console.WriteLine($"The number of items in the stack is : {stack.Count}");

            //Notice the first element in the stack is the last item put on
            Console.WriteLine($"The first element in the stack is : {stack.ElementAt(1)}");

       
        }

        public static string ReverseString(string input)
        {
            Console.WriteLine(input);

            Stack<char> stack = new Stack<char>();

            // Push each character of the string onto the stack
            foreach (char c in input)
            {
                stack.Push(c);
            }
            // Build the reversed string by popping characters from the stack
            string reversed = "";
            while (stack.Count > 0)
            {
                reversed += stack.Pop(); // add it to the string
            }
            return reversed; // return the final string
        }
    }
}
