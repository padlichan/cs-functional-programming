using FluentAssertions;
using cs_functional_programming;
using System.Configuration;
using System.Text;

namespace cs_functional_programming_Test;

public class Exercises002_Tests
{
    [Test]
    public void GetEmailList_ShouldReturnCorrectEmails()
    {
        List<string> emailList = Exercises002.GetCoolPeople();

        emailList.Should().BeEquivalentTo(new List<string>
    {
        "rich.neat@boardgamer.com",
        "poppy.mcdonnell@irishdancer.com",
        "neil.hughes@walkingoncustard.com",
        "alice.yang@midfielder.com",
        "pippa.austin@musician.com"
    });
    }
    [Test]
    public void SquaredNums_ShouldReturnCorrectNumbers()
    {
        List<int> numList = new List<int> { 5, 8, 3, 6, 67 };
        Exercises002.SquareNums(numList);
        List<int> expectedResult = new List<int> { 25, 64, 9, 36, 4489 };
        numList.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void PrintSquaredNums()
    {

        //Arrange
        List<int> numList = new List<int> { 5, 8, 3, 6, 67 };
        StringBuilder expectedResultBuilder = new StringBuilder();
        numList.ForEach(num => expectedResultBuilder.AppendLine((num*num).ToString()));
        string expectedResult = expectedResultBuilder.ToString().TrimEnd();
        string result = "";

        //Act
        var consoleOut = Console.Out;
        using(StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Exercises002.PrintSquaredNums(numList);
            result = sw.ToString().TrimEnd();
        }
        Console.SetOut(consoleOut);

        //Assert
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void GetUsernames_ShouldPrintCorrectUsername()
    {
        //Arrange
        string email = "lili.berenyi@northcoders.co.uk";
        string expectedResult = "lili.berenyi";
        string result = "";

        //Act
        var consoleOut = Console.Out;
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            Exercises002.GetUsername(email);
            result = sw.ToString().TrimEnd();
        }
        Console.SetOut(consoleOut);

        //Assert

        result.Should().Be(expectedResult);
    }

    [Test] 
    public void FilterEmails()
    {
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

        List<string> dotCom = new List<string> { "alice.yang@northcoders.com", "richard.neat@northcoders.com", "shrek@duloc.com", "neil.hughes@walkingoncustard.com" };
        List<string> dotCoDotUk = new List<string> { "link@hyrule.co.uk", "ziggy@spidersfrommars.co.uk" };
        List<string> invalid = new List<string> { "mario@plumbing.it", "csharp@microsoft.cs", "lemmy@motorhead.co,uk", "me@myhouse.sleep" };

        Dictionary<string, List<string>> expectedResult = new Dictionary<string, List<string>>();
        expectedResult[".com"] = dotCom;
        expectedResult[".co.uk"] = dotCoDotUk;
        expectedResult["invalid"] = invalid;

        Dictionary<string, List<string>> result = Exercises002.FilterEmails(emailList);

        result.Should().BeEquivalentTo(expectedResult);
    }
}
