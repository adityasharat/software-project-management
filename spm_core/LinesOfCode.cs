using System;
using System.Text.RegularExpressions;

public sealed class LinesOfCode : System.ComponentModel.Component
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static long GetLinesOfCode(string fileName)
    {

        string code;

        // get all the content of the file
        try
        {
            code = System.IO.File.ReadAllText(fileName);
        }
        catch (Exception)
        {
            throw;
        }

        string regex = @"(@(?:""[^""]*"")+|""(?:[^""\n\\]+|\\.)*""|'(?:[^'\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/";
        string noComments = Regex.Replace(code, regex, "$1");
        string[] lines = noComments.Split('\n');

        int loc = 0;

        foreach (string i in lines)
        {
            if (!i.Trim().Equals(""))
                loc++;
        }

        return loc;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static string StripComments(string fileName)
    {
        string code;

        // get all the content of the file
        try
        {
            code = System.IO.File.ReadAllText(fileName);
        }
        catch (Exception)
        {
            throw;
        }

        string regex = @"(@(?:""[^""]*"")+|""(?:[^""\n\\]+|\\.)*""|'(?:[^'\n\\]+|\\.)*')|//.*|/\*(?s:.*?)\*/";
        return Regex.Replace(code, regex, "$1");
    }
}
