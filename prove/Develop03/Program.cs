using System;
using System.Collections.Generic;

namespace Namespace
{
    static class World
    {
        static void Main()
        {
             Scripture scripture;
            Reference reference = new Reference("Proverbs", "3", "5", "6");
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
            private string chapterNumber;

            public Reference(string bookNameParam, string chapterNumberParam, string verseNumberParam)
            {
                BookName = bookNameParam;
                ChapterNumber = chapterNumberParam;
                VerseNumber = verseNumberParam;
                EndVerseNumber = "X";
            }

            public Reference(string bookNameParam, string chapterNumberParam, string verseNumberParam, string endVerseNumberParam)
            {
                BookName = bookNameParam;
                ChapterNumber = chapterNumberParam;
                VerseNumber = verseNumberParam;
                EndVerseNumber = endVerseNumberParam;
            }

            public string BookName { get; set; }
            public string ChapterNumber { get => chapterNumber; set => chapterNumber = value; }
            public string VerseNumber { get; set; }
            public string EndVerseNumber { get; set; }
            public string PrintFullReference1 { get; set; } = " ";

            public void PrintFullReference()
            {
                if (EndVerseNumber == "X")
                {
                    Console.Write(BookName + " " + ChapterNumber + ":" + VerseNumber + " ");
                }
                else
                {
                    Console.Write(BookName + " " + ChapterNumber + ":" + VerseNumber + "-" + EndVerseNumber + " ");
                }

            }
        }
class Word
    {
        private string hiddenWord;
        private bool isHidden;

        public Word(string wordParam)
        {
            HiddenWord = "";
            WordVal = wordParam;
            foreach (char x in WordVal)
            {
                HiddenWord += "_";
            }
        }

        public Word(string wordParam, bool isHiddenParam)
        {
            HiddenWord = "";
            WordVal = wordParam;
            IsHidden = isHiddenParam;

            foreach (char x in WordVal)
            {
                HiddenWord += "_";
            }
        }

        private string WordVal { get; set; }

        public string HiddenWord { get => hiddenWord; private set => hiddenWord = value; }
        public bool IsHidden { get => isHidden; private set => isHidden = value; }

        public string ShowWord()
        {
            if (IsHidden == true)
            {
                return HiddenWord;
            }
            else
            {
                return WordVal;
            }
        }

        public void SetHidden(bool isHiddenParam)
        {
            IsHidden = isHiddenParam;
            if (IsHidden)
            {
                for (int i = 0; i < HiddenWord.Length; i++)
                {
                    HiddenWord = HiddenWord.Remove(i, 1).Insert(i, "_");
                }
            }
        }
    }
}
  

    