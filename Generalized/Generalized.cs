using System;

namespace CollectionsAndGenerics.Generalized
{
    class Generalized<T>
    {
        public static void Swap(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
