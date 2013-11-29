using System;
using System.Text.RegularExpressions;

public sealed class CylomaticComplexity : System.ComponentModel.Component
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static long ComputeFromFile(string fileName)
    {
        string code = null;
        string[] pattern = {
                "for",
                "foreach",
                "while",
                "if",
                "return",
                "exit",
                "throw",
                "try",
                "finally"
            };

        long com = 0;

        try
        {
            // get all the content of the file
            code = System.IO.File.ReadAllText(fileName);
        }
        catch (Exception)
        {
            throw;
        }

        foreach (string i in pattern)
        {
            com += Regex.Matches(code, i).Count;
        }

        return com + 1;
    }

    public static long Compute(string code)
    {
        string[] pattern = {
                "for",
                "foreach",
                "while",
                "if",
                "return",
                "exit",
                "throw",
                "try",
                "finally"
            };

        long com = 0;

        foreach (string i in pattern)
        {
            com += Regex.Matches(code, i).Count;
        }

        return com + 1;
    }
}
