using System.Runtime.InteropServices.Marshalling;

namespace cs_functional_programming;

public class Exercises001
{
    public static Func<int, int> SquareIt = num => num * num;

    public static Func<int,int> AddTen = num => num+10;

    public static Predicate<string> GrammarCheck = x => x[0] == 'A' && x[^1] == '!';

    public static Func<string, string, int> SumIndices = (word1, word2) => word1.IndexOf('a')+word2.IndexOf('e');

    public static string CheckValidEmail(string input)
    {
        string correctMessage = "Email domain and user valid, please continue";
        string incorrectMessage = "Email domain and user name invalid, please check your input";

        string[] inputArray = input.Split('@');
        string username = inputArray[0];
        string domain = inputArray[1];

        if (inputArray.Length != 2) return incorrectMessage;

        Predicate<string> checkUsername = username => username.Length >= 5;
        Predicate<string> checkDomain = domain => domain == "northcoders.co.uk";

        if (checkUsername(username) && checkDomain(domain)) return correctMessage;
        return incorrectMessage;
    }
}
