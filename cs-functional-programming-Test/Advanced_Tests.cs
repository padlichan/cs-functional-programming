using cs_functional_programming;
using FluentAssertions;

namespace cs_functional_programming_Test;

public class Advanced_Tests
{
    [Test]
    public void Filter_ShouldReturnFilteredList()
    {
        List<string> names = new List<string>
        {
            "John Smith", "Emily Johnson", "Michael Brown", "Sophia Davis", "James Wilson",
            "Olivia Martinez", "Daniel Garcia", "Isabella Robinson", "Ethan Clark", "Ava Lewis"
        };

        List<string> expectedResult = new List<string> { "Olivia Martinez", "Isabella Robinson", "Emily Johnson" };

        Predicate<string> longLastName = name => name.Split(' ')[1].Length > 6? true : false;

        ListManager listManager = new ListManager(names);

        List<string> result = listManager.Filter(longLastName);

        result.Should().BeEquivalentTo(expectedResult);
    }
}