using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace cs_functional_programming;

public class Exercises002
{
    public static Func<List<string>> GetCoolPeople = () => new List<string> 
    {"rich.neat@boardgamer.com",
     "poppy.mcdonnell@irishdancer.com",
     "neil.hughes@walkingoncustard.com",
     "alice.yang@midfielder.com",
     "pippa.austin@musician.com" };

    public static Action<string> GetUsername = email => Console.WriteLine(email.Split('@')[0]);

    public static Action<List<string>> PrintCoolPeople = people => people.ForEach(Console.WriteLine);

    public static Action<List<int>> SquareNums = nums =>
    {

        for (int i = 0; i < nums.Count; i++)
        {
            nums[i] = nums[i] * nums[i];
        }
    };

    public static Action<List<int>> PrintNums = nums => nums.ForEach(Console.WriteLine);

    public static Action<List<int>> PrintSquaredNums = nums => { SquareNums(nums); PrintNums(nums); };

    public static Dictionary<string,List<string>> FilterEmails(List<string> emails )
    {
        Dictionary<string, List<string>> output = [];
        List<string> validEndings = new List<string> {".co.uk", ".com" };

        validEndings.ForEach(ending => output[ending] = emails.Where(email => email.EndsWith(ending)).ToList());
        output["invalid"] = emails.Where(email => !validEndings.Any(email.EndsWith)).ToList();

        return output;
    }
}