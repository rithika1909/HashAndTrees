using System;
namespace HashAndTrees
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Write a Statement");
            //string statement = Console.ReadLine();
            //string[] sentence = statement.Split(" ");
            //HashTables<string, string> hash = new HashTables<string, string>(sentence.Length);
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    hash.Add(Convert.ToString(i), sentence[i]);
            //}
            //string hash1 = hash.Get("5");
            //Console.WriteLine("The index Value: " + hash1);
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    int Count = 1;
            //    for (int j = i + 1; j < sentence.Length; j++)
            //    {
            //        if (hash.Get(Convert.ToString(i)) == hash.GetV(Convert.ToString(j)))
            //        {
            //            Count++;
            //            sentence[j] = null;
            //        }
            //    }
            //    if (sentence[i] != null)
            //        Console.WriteLine("The Frequency of the Word " + sentence[i] + " is " + Count);
            //}
            //Console.WriteLine("Enter Word To Be Deleted");
            //string word = Console.ReadLine();
            //int count = 0;
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (hash.Get(Convert.ToString(i)) == word)
            //    {
            //        hash.Remove(Convert.ToString(i));
            //        count++;
            //    }
            //}
            //Console.WriteLine(hash);
            //if (count == 0)
            //    Console.WriteLine("You Entered the Wrong Word. Enter the correct word to Remove");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.Display();
            binarySearch.GetSize();
            bool result = binarySearch.IfExists(67, binarySearch);
            Console.WriteLine(result);
        }
    }
}
