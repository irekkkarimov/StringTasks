using System.Runtime.InteropServices;
using strings;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please choose needed program from 1 to 3:");
        int choice = int.Parse(Console.ReadLine());
        MethodCaller(choice);
        
    }
    
    // public static void Palindrome(string[] wordsSp)
    // {
    //     foreach (var i in wordsSp)
    //     {
    //         int a = i.Length;
    //         int counter = 0;
    //         if (a % 2 == 0) 
    //         {
    //             for (int e = 0; e < (a / 2); e++)
    //             {
    //                 if (i[e] == i[a - 1 - e])
    //                 {
    //                     counter++;
    //                 }
    //             }
    //             
    //             if (counter == (a / 2))
    //             {
    //                 Console.WriteLine(i);
    //             }
    //         }
    //         else
    //         {
    //             for (int e = 0; e < ((a - 1) / 2); e++)
    //             {
    //                 if (i[e] == i[a - 1 - e])
    //                 {
    //                     counter++;
    //                 }
    //             }
    //
    //             if (counter == ((a - 1) / 2))
    //             {
    //                 Console.WriteLine(i);
    //             }
    //         }
    //     }
    // }
    //
    // public static void FirstLetter(string[] wordsSp)
    // {
    //     Dictionary<string, int> letters = Dictionary<string, int>;
    //
    //     foreach (var i in wordsSp)
    //     {
    //         if (letters.ContainsKey(i.Substring(0, 1)))
    //         {
    //             letters[i]++;
    //         }
    //         else
    //         {
    //             letters[i] = 1;
    //         }
    //     }
    //
    //     for (string i in letters.Keys)
    //     {
    //         if (letters[i] != 1)
    //         {
    //             Console.WriteLine(letters[i]);
    //         }
    //     }
    //  }    

    public static string[] ArrayMaker(string inputted)
    {
        string[] res = inputted.Split(new char[] {' ', '\n', '\t'});
        return res;
    }

    public static void StringArrayPrinter(string[] array)
    {
        foreach (var i in array)
        {
            Console.WriteLine(i);
        }
    }

    public static void MethodCaller(int choice)
    {
        if (choice == 1)
        {
            StringArrayPrinter(lesson24oct.NoRepeatedWords(lesson24oct.forStream()));
        }

        else if (choice == 2)
        {
            if (lesson24oct.IfFileConsistsWord(lesson24oct.forStream()))
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        else if (choice == 3)
        {
            if (lesson24oct.IfFileConsistsSubString(lesson24oct.FileInput()))
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
        else
        {
            Console.WriteLine("You've written wrong number.");
        }
    }
    
    











}