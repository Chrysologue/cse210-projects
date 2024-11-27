using System;

class Program
{
    static void Main(string[] args)
    {

        // Implementing a list of scripture objects, each containing a unique Reference and text.
        List<Scripture> scriptures = new List<Scripture>
        {
             new Scripture(new Reference("Proverbs", 3, 5, 6), 
                "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Ruth", 4, 2), 
                "And he took ten men of the elders of the city, and said, Sit ye down here. And they sat down."),
            new Scripture(new Reference("Esther", 10, 2), 
                "And all the acts of his power and of his might, and the declaration of the greatness of Mordecai, whereunto the king advanced him, are they not written in the book of the chronicles of the kings of Media and Persia?"),
            new Scripture(new Reference("Exodus", 4, 7),
                "And he said, Put thine hand into thy bosom again. And he put his hand into his bosom again; and plucked it out of his bosom, and, behold, it was turned again as his other flesh."),
            new Scripture(new Reference("Hosea", 12, 2, 3),
                "The LORD hath also a controversy with Judah, and will punish Jacob according to his ways; according to his doings will he recompense him. He took his brother by the heel in the womb, and by his strength he had power with God:")
        };

        //Selecting randomly a scripture from  list.
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string choice = Console.ReadLine().ToLower();
            if (choice == "quit")
            {
                break;
            }
            
            scripture.HideRandomWord(3);

            if(scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}