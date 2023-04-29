using System;
using System.IO; 

class Journal
{
    public List<Entry>_entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine (" Your entries: ");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void Save(string file)
    {
        //Save all the entries out to the file.
        using (StreamWriter outputFile = new StreamWriter(file)) {
            // store journal entries
            foreach (Entry entrie in _entries) {
                outputFile.WriteLine(entrie.GetEntry());
            }
        }    
    }

    public void Load(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            string date = parts[0];
            string prompt= parts[1];
            string text = parts[2];
            
            Entry loadEntry = new Entry(); 
            loadEntry._date = date;
            loadEntry._prompt = prompt;
            loadEntry._text = text;
            
            _entries.Add(loadEntry);
        }
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}