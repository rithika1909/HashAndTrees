using System;
namespace HashAndTrees
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a Statement");
            string statement = Console.ReadLine();
            string[] sentence = statement.Split(" ");
            HashTables<string, string> hash = new HashTables<string, string>(sentence.Length);
            for (int i = 0; i < sentence.Length; i++)
            {
                hash.Add(Convert.ToString(i), sentence[i]);
            }
            string hash1 = hash.GetV("5");
            Console.WriteLine("The index Value: " + hash1);
            for (int i = 0; i < sentence.Length; i++)
            {
                int Count = 1;
                for (int j = i + 1; j < sentence.Length; j++)
                {
                    if (hash.GetV(Convert.ToString(i)) == hash.GetV(Convert.ToString(j)))
                    {
                        Count++;
                        sentence[j] = null;
                    }
                }
                if (sentence[i] != null)
                    Console.WriteLine("The Frequency of the Word " + sentence[i] + " is " + Count);
            }
            Console.WriteLine("Enter Word To Be Deleted");
            string word = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (hash.GetV(Convert.ToString(i)) == word)
                {
                    hash.Remove(Convert.ToString(i));
                    count++;
                }
            }
            Console.WriteLine(hash);
            if (count == 0)
                Console.WriteLine("You Entered the Wrong Word. Enter the correct word to Remove");
        }
    }
}
