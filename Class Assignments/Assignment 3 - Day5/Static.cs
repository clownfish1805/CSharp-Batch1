namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            String word=Console.ReadLine();
            Console.WriteLine("Length of the word is: " + word.Length);

            Char[] wordChar = word.ToCharArray();
            Array.Reverse(wordChar);
            String revWord = new string(wordChar);
           
            Console.WriteLine("Reverse of the word is: "+ revWord);

            Console.Write("Enter first word: ");
            String word1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            String word2 = Console.ReadLine();

            if (word1 != word2) {
                Console.WriteLine("Not Equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
