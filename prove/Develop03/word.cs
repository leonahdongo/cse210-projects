namespace Namespace
{
    class Word
    {
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

        private string hiddenWord;
        private bool isHidden;

        public string HiddenWord { get => hiddenWord; set => hiddenWord = value; }
        public string WordVal { get; set; }
        public bool IsHidden { get => isHidden; set => isHidden = value; }

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

        public void setHidden(bool isHiddenParam)
        {
            IsHidden = isHiddenParam;
        }
    }
}