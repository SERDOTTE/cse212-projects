public class Translator
{
    public static void Run()
    {
        var englishToGerman = new Translator();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car")); // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???
    }

    // The main Map for mapping the source word to the translation
    private Dictionary<string, string> _words = new();

    // Optional: Sets for tracking the unique known vocabulary (ensuring uniqueness)    
    private HashSet<string> _sourceWords = new();
    private HashSet<string> _targetWords = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord)
    {
        // Record the relationship in the Map
        _words[fromWord] = toWord;

        // Record the words in the sets for tracking unique vocabulary  
        _sourceWords.Add(fromWord);
        _targetWords.Add(toWord);
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        // Uses the Map search concept (TryGetValue)
        if (_words.TryGetValue(fromWord, out var translation))
        {
            return translation;
        }

        // In case the word does not exist in the dictionary
        return "???";  // Return "???" if the word is not found in the dictionary
    }
}