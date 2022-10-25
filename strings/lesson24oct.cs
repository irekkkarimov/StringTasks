namespace strings;


public class lesson24oct
{
    public static string[] forStream()
    {
        Console.WriteLine("Please type your file's name:");
        string fileName = Console.ReadLine();
        StreamReader sd = new StreamReader(fileName);
        string text = sd.ReadToEnd();
        sd.Close();
        string[] array = Program.ArrayMaker(text);
        return array;
    }

    public static string FileInput()
    {
        Console.WriteLine("Please type your file's name:");
        string fileName = Console.ReadLine();
        StreamReader sd = new StreamReader(fileName);
        string text = sd.ReadToEnd();
        sd.Close();
        return text;
    }
    
    public static void Swap(ref int a, ref int b)
    {
        int t = b;
        b = a;
        a = t;
    }

    public static string[] NoRepeatedWords(string[] array)
    {
        Dictionary<string, int> words = new Dictionary<string, int>();
        foreach (var i in array)
        {
            if (words.ContainsKey(i) == false)
            {
                words[i] = 1;
            }
            else
            {
                words[i]++;
            }
        }

        string[] res = new string[words.Count];
        int e = 0;
        foreach (var i in words.Keys)
        {
            res[e] = i;
            e++;
        }

        return res;
    }

    public static bool IfFileConsistsWord(string[] array)
    {
        string searchWord = Console.ReadLine();
        foreach (var i in array)
        {
            if (i == searchWord)
            {
                return true;
            }
        }

        return false;
    }

    public static bool IfFileConsistsSubString(string text)
    {
        Console.WriteLine("Please, input substring you want to search for:");
        string substring = Console.ReadLine();
        for (int i = 0; i < (text.Length - substring.Length); i++)
        {
            int counter = 0;
            for (int e = 0; e < substring.Length; e++)
            {
                if (text[i + e] == substring[e])
                {
                    counter++;
                }

                if (counter == substring.Length)
                {
                    return true;
                }
            }
        }

        return false;
    }
}