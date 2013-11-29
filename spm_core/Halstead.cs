using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Halstead : System.ComponentModel.Component
{
    #region Members

    /// <summary>
    ///  Hash map of the operands encountered
    /// </summary>
    private static Dictionary<string, int> dictOperands = null;

    /// <summary>
    /// Hash map of the operators encountered
    /// </summary>
    private static Dictionary<string, int> dictOperators = null;

    /// <summary>
    /// Set of operators defined to be searched
    /// </summary>
    private static string[][] operators = {
            new string[]{"==", "=="},
            new string[]{"!=", "!="},
            new string[]{"<=", "<="},
            new string[]{">=", ">="},
            new string[]{"&&", "&&"},
            new string[]{"=", "="},
            new string[]{"\\+", "+"},
            new string[]{"-", "-"},
            new string[]{"\\|\\|", "||"},
            new string[]{"<", "<"},
            new string[]{">", ">"},
            new string[]{"&", "&"},
            new string[]{",", ","},
            new string[]{"if", "if"}
        };

    /// <summary>
    /// Set of defined data types (primitives)
    /// </summary>
    private static string[] types = {
            "int ", "char ", "float ", "long ", "double "
        };

    /// <summary>
    /// Count of operands
    /// </summary>
    private static int operandCount = 0;


    /// <summary>
    /// Count of operators
    /// </summary>
    private static int operatorCount = 0;

    #endregion

    #region Public Methods
    /// <summary>
    /// 
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static ResultSet calculate(string fileName)
    {
        dictOperands = new Dictionary<string, int>();
        dictOperators = new Dictionary<string, int>();

        string code = null;
        try
        {
            code = System.IO.File.ReadAllText(fileName);
        }
        catch (Exception)
        {
            throw;
        }

        parse(code);

        double n1 = 0, n2 = 0, N1 = 0, N2 = 0;

        foreach (KeyValuePair<string, int> entry in dictOperators)
        {
            if (entry.Key.Length > 0 && entry.Value > 0)
            {
                n1++;
                N1 += entry.Value;
            }
        }

        foreach (KeyValuePair<string, int> entry in dictOperands)
        {
            if (entry.Key.Length > 0 && entry.Value > 0)
            {
                n2++;
                N2 += entry.Value;
            }
        }

        double n = n1 + n2;
        double N = N1 + N2;
        double V = N * log2(n);
        double Vs = (2 + n2) * log2(2 + n2);
        double L = Vs / V;
        double D = 1 / L;
        double E = D * V;
        double Ns = n1 * log2(n1) + n2 * log2(n2);
        double Ls = 2 * n2 / (n1 * N2);
        double Ds = 1 / Ls;
        double Es = V * Ds;
        double T = Es / 18;

        return new ResultSet(n1, n2, N1, N2, n, N, V, Vs, L, D, E, Ns, Ls, Ds, Es, T);
    }
    #endregion

    #region Private Methods
    private static void parse(string code)
    {

        string tempCode = code;

        // find number pf occurnaces of the following
        incrementKey(dictOperators, "{}", Regex.Matches(code, "\\{").Count);
        incrementKey(dictOperators, "()", Regex.Matches(code, "\\(").Count);
        incrementKey(dictOperators, "[]", Regex.Matches(code, "\\[").Count);
        incrementKey(dictOperators, ";", Regex.Matches(code, ";").Count);
        incrementKey(dictOperators, "return", Regex.Matches(code, "return").Count);

        // replace the encountered strings with space
        code = code.Replace("{", " ");
        code = code.Replace("}", " ");
        code = code.Replace("[", " ");
        code = code.Replace("]", " ");
        code = code.Replace("(", " ");
        code = code.Replace(")", " ");
        code = code.Replace(";", " ");
        code = code.Replace("else", " ");
        code = code.Replace("return", " ");

        //Count number of string literals and remove them
        string[] tmp = code.Split('\n');

        for (int i = 0; i < tmp.Length; i++)
        {
            //Double quotes
            string[] x = tmp[i].Split('\"');
            operandCount += x.Length / 2;
            tmp[i] = "";
            for (int j = 0; j < x.Length; j++)
            {
                if (j % 2 == 0)
                {
                    tmp[i] = tmp[i] + (x[j]);
                }
                else
                {
                    incrementKey(dictOperands, x[j], 1);
                }
            }

            //Single quotes
            x = tmp[i].Split('\'');
            operandCount += x.Length / 2;
            tmp[i] = "";
            for (int j = 0; j < x.Length; j++)
            {
                if (j % 2 == 0)
                {
                    tmp[i] = tmp[i] + (x[j]);
                }
                else
                {
                    incrementKey(dictOperands, x[j], 1);
                }
            }
        }

        //Count other objects
        for (int i = 0; i < tmp.Length; i++)
        {
            if (tmp[i].Trim().StartsWith("#"))
            {
                continue;
            }

            //Count number of operators
            for (int k = 0; k < operators.GetLength(0); k++)
            {
                incrementKey(dictOperators, operators[k][1], Regex.Matches(tmp[i], operators[k][0]).Count);
                tmp[i] = tmp[i].Replace(operators[k][1], " ");
            }

            //Count number of variables and constants
            for (int k = 0; k < types.Length; k++)
            {
                if (tmp[i].IndexOf(types[k]) != -1)
                {
                    incrementKey(dictOperators, types[k], 1);
                    tmp[i] = tmp[i].Replace(types[k], " ");
                }
            }

            string[] op = tmp[i].Split(' ');
            for (int k = 0; k < op.Length; k++)
            {
                if (op[k].Trim().Length != 0)
                {
                    incrementKey(dictOperands, op[k].Trim(), 1);
                }
            }
        }

        //Count function calls and adjust the metrics
        tmp = tempCode.Split('\n');

        //Remove extra '()' counted in main-declaration and if-statements
        int c = 1;
        if (dictOperators.ContainsKey("if"))
        {
            c += dictOperators["if"];
        }

        decrementKey(dictOperators, "()", c);

        for (int i = 0; i < tmp.Length; i++)
        {
            if (tmp[i].IndexOf("(") != -1 && tmp[i].IndexOf(";") != -1)
            {
                string[] fn = tmp[i].Substring(0, tmp[i].IndexOf("(")).Split(' ');
                string cfn = fn[fn.Length - 1].Trim();
                bool isOp = false;
                for (int k = 0; k < operators.GetLength(0); k++)
                {
                    if (cfn.Equals(operators[k][1]))
                    {
                        isOp = true;
                        break;
                    }
                }

                if (!isOp)
                {
                    decrementKey(dictOperands, cfn, 1);
                    decrementKey(dictOperators, "()", 1);
                    incrementKey(dictOperators, cfn, 1);
                }
            }
        }
    }

    private static void decrementKey(Dictionary<string, int> dict, string x, int value)
    {
        if (dict.ContainsKey(x))
        {
            dict[x] = dict[x] - value;
        }
    }

    private static void incrementKey(Dictionary<string, int> dict, string x, int value)
    {
        if (dict.ContainsKey(x))
        {
            dict[x] = dict[x] + value;
        }
        else
        {
            dict.Add(x, value);
        }
    }

    private static double log2(double n)
    {
        return (Math.Log10(n) / Math.Log10(2));
    }
    #endregion

    public class ResultSet
    {
        public double n1;
        public double n2;
        public double N1;
        public double N2;
        public double n;
        public double N;
        public double V;
        public double Vs;
        public double L;
        public double D;
        public double E;
        public double Ns;
        public double Ls;
        public double Ds;
        public double Es;
        public double T;

        public ResultSet(double n1, double n2, double N1, double N2, double n,
                double N, double V, double Vs, double L, double D, double E,
                double Ns, double Ls, double Ds, double Es, double T)
        {

            this.n1 = n1;
            this.n2 = n2;
            this.N1 = N1;
            this.N2 = N2;
            this.n = n;
            this.N = N;
            this.V = V;
            this.Vs = Vs;
            this.L = L;
            this.D = D;
            this.E = E;
            this.Ns = Ns;
            this.Ls = Ls;
            this.Ds = Ds;
            this.Es = Es;
            this.T = T;

        }

        private double round(double n)
        {
            return (double)((int)(n * 100)) / 100;
        }
    }

}
