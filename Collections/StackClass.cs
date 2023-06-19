using System;
using System.Collections.Generic;


namespace CollectionsAndGenerics.Collections
{
    class StackClass
    {
        public static void UseGenericStack()
        {
            {
                Stack<string> stackOfPeople = new Stack<string>();
                stackOfPeople.Push("Homer");
                stackOfPeople.Push("Marge");
                stackOfPeople.Push("Lisa");
                Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
                Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
                Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
                Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
                try
                {
                    Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek());
                    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("\nError! {0}", ex.Message); // Ошибка! Стек пуст.
                }

                }
        }
    }
}

