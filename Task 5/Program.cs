using System;

public class StringAnalyzer
{
    public static (int, int) CountVowelsAndConsonants(string input)
    {
        int vowelCount = 0;
        int consonantCount = 0;

        foreach (char c in input.ToLower())
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowelCount++;
                else
                    consonantCount++;
            }
        }

        return (vowelCount, consonantCount);
    }
}

