public class Solution
{
    public bool DetectCapitalUse(string word)
    {

        if (word.Length < 1 || word.Length > 100)
        {
            return false;
        }

        if (word == word.ToUpper() || word == word.ToLower())
        {
            return true;
        }

        if (char.IsLower(word[0]))
        {
            return false;
        }

        if (char.IsUpper(word[0]))
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
