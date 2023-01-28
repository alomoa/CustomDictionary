CustomDictionary dictionary = new CustomDictionary();
dictionary.insert("Greeting", "Hello there");
dictionary.insert("Greeting", "Good evening");

Console.WriteLine(dictionary.get("Greeting"));

public class CustomDictionary
{
    private string[] Values;

    public CustomDictionary()
    {
        Values = new string[8];
    }

    private int getHash(string key)
    {
        string firstCharacter = key.Substring(0,1).ToUpper();
        int hash = -1;

        for(int i = 0; i<26; i++)
        {
            int ASCII = 65 + i;
            string tempchar = ((char)ASCII).ToString();
            
            if (firstCharacter.Equals(tempchar)){
                hash = 1;
                break;
            }

        }

        return hash;
    }

    public void insert(string key, string value)
    {
        int hash = this.getHash(key);

        if (!(hash == -1))
        {
            Values[hash] = value;
        }
        else
        {
            Console.WriteLine("Use only strings please");
        }
    }

    public string get(string key)
    {
        int hash = this.getHash(key);

        if(!(hash == -1))
        {
            return Values[hash];
        }
        else
        {
            return "Does not exist";
        }
    }
}


