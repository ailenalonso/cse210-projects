using System.Text.RegularExpressions;

class Word
{
    static private Word _instance = new Word();

    static public Word getInstance() { return _instance; }

    public void RandomlyHideWords(Reference original)
    {
        Reference modified = new Reference();
        Regex validate = new Regex(@"[a-zA-Z.,!-;]");

        while (true)
        {
            Console.Clear();
            original.DisplayWithVerse();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish: ");

            List<string> hiddenTexts = new List<string>();

            // End the program
            if (Console.ReadLine() == "quit") break;

            original.text.ForEach(verse =>
            {
                // Converting the verse into an array of words
                List<string> words = verse.Split(' ').ToList();
                int hCount = 0;
                
                for (int i = 0; i < words.Count(); i++)
                {
                    // Randomly hide a word
                    bool shallHide = new Random().Next(0, 100) % 3 == 0 ? true : false;
                    if (shallHide && !words[i].Contains("_"))
                    {
                        hCount += 1;
                        words[i] = new string('_', words[i].Count());
                    }
                    if (hCount == 4) i = words.Count();
                }
                
                verse = String.Join(' ', words);
                hiddenTexts.Add(verse);
            });

            modified.book = original.book;
            modified.chapter = original.chapter;
            modified.verse = original.verse;
            modified.text = hiddenTexts;

            original = modified;

            // Checks if it's no longer words to hide
            if (!validate.IsMatch(String.Join("\n", hiddenTexts))) break;
        }

        Console.Clear();
        original.DisplayWithVerse();
        Console.WriteLine("\nI hope you memorized the scripture!");
    }
}
