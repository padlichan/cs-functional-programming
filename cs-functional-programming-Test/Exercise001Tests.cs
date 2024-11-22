using cs_functional_programming;
using FluentAssertions;

namespace cs_functional_programming_Test
{
    public class Tests
    {

        [Test]
        public void SquareItTest()
        {
            int input = 3;
            int expected = 9;

            int result = Exercises001.SquareIt(input);

            result.Should().Be(expected);
        }

        [Test]
        [TestCase("liliBerenyi@northcoders.co.uk", "Email domain and user valid, please continue",TestName = "Valid email")]
        [TestCase("lili@northcoders.co.uk", "Email domain and user name invalid, please check your input", TestName = "Invalid username")]
        [TestCase("liliBerenyi@northcoders.com", "Email domain and user name invalid, please check your input", TestName = "Invalid domain")]

        public void ValidEmailFormatTest(string email, string expectedResult)
        {
            string result = Exercises001.CheckValidEmail(email);
            result.Should().Be(expectedResult);
        }

        [Test]
        public void GrammarCheckTest()
        {
            List<string> words = new List<string> { "Amazing!", "apple!", "Awesome!", "Artichoke" };
            List<bool> result = words.Select(new Func<string, bool>(Exercises001.GrammarCheck)).ToList();
            List<bool> expectedResult = new List<bool> {true, false, true, false };
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void SumIndicesTest()
        {
            int result = Exercises001.SumIndices("star", "pole");
            result.Should().Be(5);
        }

        [Test]
        public void AddTenTest()
        {
            List<int> numbers = new List<int> { 4, 15, 55, 78, 12 };
            List<int> result = numbers.Select(Exercises001.AddTen).ToList();
            List<int> expectedResult = new List<int>{ 14, 25, 65, 88, 22 };
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}