using JNTechAssessment.Lib;

namespace JNTechAssessment.Tests
{
    public class UnitTest
    {
        private readonly MatchingBracket _matchingBracket = new MatchingBracket();

        [Fact]
        public void TestCase_1()
        {
            string input = "{}";

            Assert.True(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_2()
        {
            string input = "}{";

            Assert.False(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_3()
        {
            string input = "{{}";

            Assert.False(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_4()
        {
            string input = @""""""; // equivalent to double quote ""
            bool isMatch = _matchingBracket.IsMatch(input);

            Assert.True(isMatch);
        }

        [Fact]
        public void TestCase_5()
        {
            string input = "{abc...def}";

            Assert.True(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_6()
        {
            string input = "}{}...";

            Assert.False(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_7()
        {
            string input = "abc}{..}{";

            Assert.False(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_8()
        {
            string input = "abc}{..}{...}";

            Assert.False(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_9()
        {
            string input = "abc...def";

            Assert.True(_matchingBracket.IsMatch(input));
        }

        [Fact]
        public void TestCase_10()
        {
            string input = "";

            Assert.True(_matchingBracket.IsMatch(input));
        }
    }
}