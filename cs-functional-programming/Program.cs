using System.Threading.Channels;

namespace cs_functional_programming;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> coolPeople = Exercises002.GetCoolPeople();
        Exercises002.PrintCoolPeople(coolPeople);

        Console.WriteLine();

        List<int> numList = new List<int> { 5, 8, 3, 6, 67 };
        Exercises002.PrintSquaredNums(numList);

        Console.WriteLine();

        List<string> emailList = new List<string>
        {
            "alice.yang@northcoders.com",
            "richard.neat@northcoders.com",
            "mario@plumbing.it",
            "link@hyrule.co.uk",
            "shrek@duloc.com",
            "neil.hughes@walkingoncustard.com",
            "csharp@microsoft.cs",
            "ziggy@spidersfrommars.co.uk",
            "lemmy@motorhead.co,uk",
            "me@myhouse.sleep"
        };

        var filteredEmails = Exercises002.FilterEmails(emailList);

        foreach (var item in filteredEmails)
        {
            Console.WriteLine(item.Key);
            item.Value.ForEach(Console.WriteLine);
        }
    }
}
