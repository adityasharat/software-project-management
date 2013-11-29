using System;

public class FunctionPoint : System.ComponentModel.Component
{
    /// <summary>
    /// Weights for functional units of different complexities. EI, EO, EQ, ILF, EIF
    /// </summary>
    private static int[,] _weights = {
            {3, 4, 6},
            {4, 5, 7},
            {3, 4, 6},
            {7, 10, 15},
            {5, 7, 10}
        };

    public static int[,] Weights
    {
        get
        {
            return _weights;
        }
    }

    /// <summary>
    /// This function calculates and returns the Adjusted function point of a software based on the functionals units.
    /// </summary>
    /// <param name="fp">Number of different functional units of different complexities.Each should be a positive integral value.</param>
    /// <param name="caf">Array of integers containing the weight factors for each effort adjustment factor.
    /// Each value should be between 0 and 5</param>
    /// <returns>The function points</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static double Calculate(int[][] fp, int[] caf)
    {
        if (fp == null || caf == null)
        {
            throw new ArgumentException("Variable(s) not initilized.");
        }

        if (fp[0].Length != 3)
        {
            throw new ArgumentException("Please check the argument(s) passed.");
        }

        bool error = false;
        foreach (int[] i in fp)
        {
            foreach (int j in i)
            {
                if (j < 0)
                {
                    error = true;
                    break;
                }
            }
        }

        if (error)
        {
            throw new ArgumentException("Please check the argument(s) passed.");
        }
        else
        {
            return UFP(fp) * CAF(caf);
        }
    }

    private static long UFP(int[][] fp)
    {
        long UFP = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                UFP += _weights[i, j] * fp[i][j];
            }
        }
        return UFP;
    }

    private static double CAF(int[] caf)
    {
        if (caf == null)
        {
            return 3.0;
        }
        int sum = 0;
        foreach (int i in caf)
        {
            sum += i;
        }
        return (0.65 + (0.01 * sum));
    }
}
