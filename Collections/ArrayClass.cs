using System;
using System.Collections.Generic;


namespace CollectionsAndGenerics.Collections
{
    class ArrayClass
    {
        private string[] _array = { "First", "Second", "Third" };


        

        public void ImpArrayMethode()
        {
            Console.WriteLine("This array has {0} items.", _array.Length);
            Console.WriteLine();

            foreach (string i in _array)
            {

                Console.WriteLine("Array Entry: {0}", i);

            }

            Console.WriteLine();

            Array.Reverse(_array);

            foreach (string i in _array)
            {

                Console.WriteLine("Array Entry: {0}", i);

            }

        }

      
    }
}
