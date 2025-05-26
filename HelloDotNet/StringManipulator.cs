using System;

class StringManipulator
{
    public static string MakeUpper(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        return input.ToUpper();
    }

    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        return new string(input.Reverse().ToArray());
    }

    public static bool ContainsLetter(string input, char letter)
    {
        return input.Contains(letter);
    }
}
