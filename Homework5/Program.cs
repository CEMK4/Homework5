using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.WriteLine("Введите предложение:");
            sentence = Console.ReadLine();
            PrintWords(GetWords(sentence));

            Console.WriteLine($"\nИсходное предложение в обротном порядке:\n{ReverseWords(sentence)}");
        }

        static string[] GetWords(string sentence)
        {
            return sentence.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

        static void PrintWords(string[] words)
        {
            Console.WriteLine("\nВсе слова предложения:");
            foreach (string word in words)
                Console.WriteLine(word);
        }

        static string ReverseWords(string sentence)
        {
            string[] words = GetWords(sentence);
            string reverseSentence = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reverseSentence += words[i] + " ";
            }
            return reverseSentence;
        }
    }
}
