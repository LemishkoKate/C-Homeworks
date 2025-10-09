namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text (press Enter twice to finish):");

            string text = "";
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                text += line + \n;
            }

            Console.Write("Enter a baaaaad word: ");
            string badWord = Console.ReadLine();

            string replacement = new string('*', badWord.Length);
            string newText = "";
            int count = 0;

            for (int i = 0; i < text.Length;)
            {
                bool match = true;

                for (int j = 0; j < badWord.Length; j++)
                {
                    if (i + j >= text.Length || text[i + j] != badWord[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    newText += replacement;
                    i += badWord.Length;
                    count++;
                }
                else
                {
                    newText += text[i];
                    i++;
                }
            }

            Console.WriteLine("\nResult:");
            Console.WriteLine(newText);
        }
    }
}
