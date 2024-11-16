using System;
using System.IO;
class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry eachEntry in _entries)
        {
            eachEntry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outPutFile = new StreamWriter(filename))
        {
            foreach(Entry eachEntry in _entries)
        {
            outPutFile.WriteLine($"{eachEntry._date}|{eachEntry._promptText}|{eachEntry._entryText}");
        }
        }
    }
    public void LoadFromFIle(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string content;
            while ((content = reader.ReadLine()) != null)
            {
                string[] parts = content.Split("|");
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];

                Entry entry = new Entry(promptText, entryText)
                {
                    _date = date
                };
                _entries.Add(entry);
            }
        }
    }
}