class Scripture
{
    private List<Reference> _library;

    public Scripture()
    {
        JsonFileReader reader = new JsonFileReader();
        this._library = reader.Read<List<Reference>>();
    }

    public void DisplayLibrary()
    {
        this._library.ForEach(reference =>
        {
            Console.Write($"{this._library.IndexOf(reference) + 1} — ");
            reference.Display();
        });
    }

    public Reference ChooseRandom()
    {
        int r = new Random().Next(0, this._library.Count() - 1);
        return this._library[r];
    }
    public Reference ChooseOne(int r)
    {
        return this._library[r];
    }
}