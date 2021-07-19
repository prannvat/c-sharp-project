using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summarising_text
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "This is going to be a really really really really really long text.";

            var summary = SummariseText(text, 25); // as the 'SummariseText' method takes maxLength as a parameter too, user can easily chanhge the maxLength like I have here and changed ftrom the default 20 to 25.
            Console.WriteLine(summary);

        }
        static string SummariseText(string sentence, int maxLength = 20)
        {


            if (sentence.Length < maxLength)
                return sentence;


            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();


            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }


            return String.Join(" ", summaryWords) + "....";



        }
    }
}
