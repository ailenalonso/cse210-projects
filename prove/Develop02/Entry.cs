using System; 

class Entry 
{
    public string _date;
    public string _prompt; 
    public string _text;

    public void Display()
    {
        Console.WriteLine ($"{_date} - {_prompt} - {_text}");
    }

    public string GetEntry()
    {
        return $"{this._date}~~{this._prompt}~~{this._text}";
    }
}