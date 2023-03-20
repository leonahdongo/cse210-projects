using System;

namespace Namespace
{
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
}