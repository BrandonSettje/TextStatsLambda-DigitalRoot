using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            textStats("Mary had a little lamb. Her new fleece coat was white as snow. Now farmer Bob has a naked lamb.");
            Console.ReadKey();
            Console.WriteLine(DigitalRoot("31337"));
            Console.WriteLine(DigitalRoot("45734"));
            Console.ReadKey();
        }

        public static int DigitalRoot(string rootThisNumber)
        {
            if (rootThisNumber.All(x => char.IsNumber(x)))
            {
                while(rootThisNumber.Length > 1)
                {
                    int totalNum = 0;
                    foreach (char digit in rootThisNumber)
                    {
                        totalNum += int.Parse(digit.ToString());
                    }
                    rootThisNumber = totalNum.ToString();
                }
            
                //completed the loop, only has 1 digit
                // return rootThis as a number
                return int.Parse(rootThisNumber);
            }
            else 
            {
                //false, not every character was a number
                return -1;
            }
            
        }
        public static void textStats(string inputString)
        {
            Console.WriteLine("Number of characters: " + inputString.ToLower().Count());
            Console.WriteLine("Number of words: {0}", NumberOfWords(inputString));
            Console.WriteLine("Number of vowels: {0}", NumberOfVowels(inputString));
            Console.WriteLine("Number of consonants: {0}", NumberOfConsonants(inputString));
            Console.WriteLine("Number of special characters: {0}", NumberOfSpecialCharacters(inputString));
            Console.WriteLine("Longest Word: {0}", LongestWord(inputString));
            Console.WriteLine("Shortest Word: {0}", ShortestWord(inputString));


        }

        public static int NumberOfWords(string inputString)
        {
            //List<string> wordString = new List<string>();
            //int wordCount = inputString.Split(' ').ToList().Count();
            return inputString.Split(' ').ToList().Count();
        }

        public static int NumberOfVowels(string inputString)
        {
            //int vowelCounter = inputString.Count(x => "aeiou".Contains(x.ToString().ToLower()));
            return inputString.Count(x => "aeiou".Contains(x.ToString().ToLower()));
        }

        public static int NumberOfConsonants(string inputString)
        {
            //int consonCounter = inputString.Count( x => "qwrtyplkjhgfdszxcvbnm".Contains(x.ToString().ToLower()));
            return inputString.Count(x => "qwrtyplkjhgfdszxcvbnm".Contains(x.ToString().ToLower()));
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => "!@$#%^&*()';?,. ".Contains(x.ToString().ToLower()));
        }

        public static string LongestWord(string inputString)
        {
            return inputString.Split(' ').ToList().OrderByDescending(x => x.Length).First();
        }

        public static string ShortestWord(string inputString)
        {
            return inputString.Split(' ').ToList().OrderBy(x => x.Length).First();
        }


    }
}
