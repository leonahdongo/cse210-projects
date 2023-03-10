using System;
using System.Collections.Generic;

namespace Namespace
class Program
{
    static class Program
    static void Main(string[] args)
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Develop05 World!");
        }
        Console.WriteLine("Hello World!");
    }
}

namespace Scripture
{
    static class HelloWorld
    {
        static void Main()
        {
            ProgramManager manager = new();
            ProgramManager.Run();
        }
    }

    internal static class ProgramManager
    {
        public static void Run()
        {
            Scripture scripture;
            Reference reference = new("Proverbs", "3", "5", "6");

            Random random = new();
            int randomNumber;

            string quitString = "";
            const string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            string[] splitScriptureText = scriptureText.Split(" ");

            List<Word> wordList = new();

            foreach (string x in splitScriptureText)
            {
                wordList.Add(new Word(x));
            }

            scripture = new Scripture(reference, wordList);

            while (quitString != "quit")
            {
                reference.PrintFullReference();
                foreach (Word word in scripture.GetScriptureText())
                {
                    Console.Write(word.ShowWord() + " ");
                }
                Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
                quitString = Console.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    randomNumber = random.Next(0, scripture.GetScriptureText().Count);
                    scripture.GetScriptureText()[randomNumber].SetHidden(true);
                    Console.WriteLine(randomNumber);
                }
            }
        }
    }

    class Scripture
    {
        private readonly List<Word> wordList;

        public Scripture(Reference reference, List<Word> wordList)
        {
            Reference = reference;
            this.wordList = wordList;
        }

        public Reference Reference { get; }

        internal List<Word> GetScriptureText()
        {
            return wordList;
        }
    }

    class Reference
    {
        private string book;
        private readonly string chapter;
        private string verse;
        private string v;

        public Reference(string bookParam, string chapterParam, string verseParam)
        {
            book = bookParam;
            chapter = chapterParam;
            verse = verseParam;
        }

        public Reference(string bookParam, string chapterParam, string verseParam, string v) : this(bookParam, chapterParam, verseParam)
        {
            this.v = v;
        }

        public void PrintFullReference()
        {
            Console.WriteLine($"{book} {chapter}:{verse}");
        }
    
    }
    

    