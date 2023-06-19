using System;
using CollectionsAndGenerics.Collections;
using CollectionsAndGenerics.Generalized;

namespace CollectionsAndGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayClass arrayClass = new ArrayClass();
            arrayClass.ImpArrayMethode();

            Console.WriteLine("*********************");
            ArrayListClass arrayListClass = new ArrayListClass();   
            arrayListClass.ImplArrayLisMethods();

            GenericList.UseGenencList();

            StackClass.UseGenericStack();
            Queue.ProcessQueue();

            Console.WriteLine("***** Fun with Custom Generic Methods *****\n");
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine("Before swap: num1 = {0}, num2 = {1}", num1, num2);

            Generalized<int>.Swap(ref num1, ref num2);
            Console.WriteLine("After swap: num1 = {0}, num2 = {1}", num1, num2);

            Console.ReadLine();
        }
    }
}
