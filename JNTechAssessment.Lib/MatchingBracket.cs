using System.Text;

namespace JNTechAssessment.Lib
{
    public class MatchingBracket
    {
        public bool IsMatch(string input)
        {
            if (input == "") return true;

            var pairOfBrackets = new StringBuilder(input.Length);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{')
                {
                    pairOfBrackets.Append(input[i]);
                }

                if (input[i] == '}')
                {
                    int bracketsLength = pairOfBrackets.Length;
                    if(bracketsLength == 0)
                    {
                        return false;
                    }

                    char lastChar = pairOfBrackets[bracketsLength - 1];
                    if(lastChar == '{')
                    {
                        pairOfBrackets.Remove(bracketsLength - 1, 1);
                    }
                }
            }

            return pairOfBrackets.Length == 0;
        }
    }
}