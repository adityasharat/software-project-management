using cocomo;
using System;

public sealed class Cocomo : System.ComponentModel.Component
{
    #region Properties

    private static readonly float[,] _weights = {
            {2.4f, 1.05f, 2.5f, 0.38f},
            {3.0f, 1.12f, 2.5f, 0.35f},
            {3.6f, 1.20f, 2.5f, 0.32f}
        };

    /// <summary>
    ///  The weight factors of different modes of the basic model.
    ///  Organic, Semi-Detached, Embedded
    /// </summary>
    public static float[,] Weights
    {
        get
        {
            return _weights;
        }
    }

    private static readonly float[,] _interWeights = {
            {3.2f, 1.05f, 2.5f, 0.38f},
            {3.0f, 1.12f, 2.5f, 0.35f},
            {2.8f, 1.20f, 2.5f, 0.32f}
        };

    /// <summary>
    /// The weight factors of different modes of the intermediate model.
    /// Organic, Semi-Detached, Embedded
    /// </summary>
    public static float[,] IntermediateWeights
    {
        get
        {
            return _interWeights;
        }
    }

    private static readonly float[,] _costDrivers = {
            {0.75f, 0.88f, 1.00f, 1.15f, 1.40f, 1},
            {1f, 0.94f, 1.00f, 1.08f, 1.16f, 1},
            {0.70f, 0.85f, 1.00f, 1.15f, 1.30f, 1.65f},
            {1f, 1f, 1.00f, 1.11f, 1.30f, 1.66f},
            {1f, 1f, 1.00f, 1.06f, 1.21f, 1.56f},
            {1f, 0.87f, 1.00f, 1.15f, 1.30f, 1f},
            {1f, 0.87f, 1.00f, 1.07f, 1.15f, 1f},
            {1.46f, 1.19f, 1.00f, 0.86f, 0.71f, 1f},
            {1.29f, 1.13f, 1.00f, 0.91f, 0.82f, 1f},
            {1.42f, 1.17f, 1.00f, 0.86f, 0.70f, 1f},
            {1.21f, 1.10f, 1.00f, 0.90f, 1f, 1f},
            {1.14f, 1.07f, 1.00f, 0.95f, 1f, 1f},
            {1.24f, 1.10f, 1.00f, 0.91f, 0.82f, 1f},
            {1.24f, 1.10f, 1.00f, 0.91f, 0.83f, 1f},
            {1.23f, 1.08f, 1.00f, 1.04f, 1.10f, 1f}
        };

    /// <summary>
    /// Cost drivers for computing in the intermediate model.
    /// For complete documentation refer S.E. course book.
    /// </summary>
    public static float[,] CostDrivers
    {
        get
        {
            return _costDrivers;
        }
    }

    private static float[,] _mu = {
            {0.06f, 0.16f, 0.26f, 0.42f, 0.16f},
            {0.06f, 0.16f, 0.24f, 0.38f, 0.22f},
            {0.07f, 0.17f, 0.25f, 0.33f, 0.25f},
            {0.07f, 0.17f, 0.24f, 0.31f, 0.28f},
            {0.08f, 0.18f, 0.25f, 0.26f, 0.31f},
            {0.08f, 0.18f, 0.24f, 0.24f, 0.34f}
        };

    /// <summary>
    /// Life cycle phase value of mu for different values of Size.
    /// </summary>
    public static float[,] Mu
    {
        get
        {
            return _mu;
        }
    }

    private static float[,] _tau = {
            {0.10f, 0.19f, 0.24f, 0.39f, 0.18f},
            {0.12f, 0.19f, 0.21f, 0.34f, 0.26f},
            {0.20f, 0.26f, 0.21f, 0.27f, 0.26f},
            {0.22f, 0.27f, 0.19f, 0.25f, 0.29f},
            {0.36f, 0.36f, 0.18f, 0.18f, 0.28f},
            {0.40f, 0.38f, 0.16f, 0.16f, 0.30f}
        };

    /// <summary>
    /// Life cycle phase value of tau for different values of Size.
    /// </summary>
    public static float[,] Tau
    {
        get
        {
            return _tau;
        }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// This function calculates the effort, duration, average staff size in basic model and returns the result in a ResultSet object.
    /// </summary>
    /// <param name="kloc">Kilo lines of code. Should be positive floating value.</param>
    /// <param name="mode">mode of Cocomo used. Should be an 0, 1, or 2; Corresponding</param>
    /// <returns>ResultSet that encapsulates all the results.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static ResultSet Calculate(float kloc, int mode)
    {
        if (kloc <= 0 || mode < 0 || mode > 2)
        {
            throw new ArgumentException("Please check the argument(s) passed.");
        }

        float eff = (float)(_weights[mode, 0] * (Math.Pow(kloc, _weights[mode, 1])));
        float dur = (float)(_weights[mode, 2] * (Math.Pow(eff, _weights[mode, 3])));
        float avgStfSiz = eff / dur;
        float prod = kloc / eff;

        return new ResultSet(eff, dur, avgStfSiz, prod);
    }

    /// <summary>
    /// This function calculates the effort, duration, average staff size in intermediate model and returns the result in a ResultSet object.
    /// </summary>
    /// <param name="kloc">Kilo lines of code. Should be positive floating value.</param>
    /// <param name="mode">mode mode of Cocomo used. Should be an 0, 1, or 2; Corresponding to Organic, Semi-Detached and Embedded</param>
    /// <param name="eafs">eafs Array of integers containing the weight factors for each effort adjustment factor.
    /// Each value should be between 0 and 5, corresponding to very low, low, nominal, high, very high, extra high.</param>
    /// <returns>ResultSet that encapsulates all the results.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    public static ResultSet Calculate(float kloc, int mode, int[] eafs)
    {
        if (kloc < 0 || mode < 0 || mode > 2 || eafs.Length != 15)
        {
            throw new ArgumentException("Please check the argument(s) passed.");
        }

        if (eafs == null)
        {
            throw new ArgumentNullException("Variable not initilized.");
        }

        float eaf = 1;
        int k = 0;
        foreach (int i in eafs)
        {
            eaf *= _costDrivers[k, eafs[i]];
            k++;
        }

        float eff = (float)(_interWeights[mode, 0] * (Math.Pow(kloc, _interWeights[mode, 1])) * eaf);
        float dur = (float)(_interWeights[mode, 2] * (Math.Pow(eff, _interWeights[mode, 3])));
        float avgStfSiz = eff / dur;
        float prod = kloc / eff;

        return new ResultSet(eff, dur, avgStfSiz, prod);
    }

    /// <param name="kloc">Kilo lines of code. Should be positive floating value.</param>
    /// <param name="mode">mode mode of Cocomo used. Should be an 0, 1, or 2; Corresponding to Organic, Semi-Detached and Embedded</param>
    /// <param name="eafs">eafs Array of integers containing the weight factors for each effort adjustment factor.
    /// Each value should be between 0 and 5, corresponding to very low, low, nominal, high, very high, extra high.</param>
    /// <param name="DD">Percentage of design documentation to be modified. Should be a floating point value between 0 and 100.</param>
    /// <param name="C">Percentage of code to be modified. Should be a floating point value between 0 and 100.</param>
    /// <param name="I">Percentage of modification required for integration. Should be a floating point value between 0 and 100.</param>
    /// <returns>ResultSet that encapsulates all the results.</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="ArgumentNullException"></exception>
    public static DetailedResultSet Calculate(float kloc, int mode, int[] eafs, float DD, float C, float I)
    {
        if (kloc < 0 || mode < 0 || mode > 2 || eafs.Length != 15 || DD < 0 || DD > 100 || C < 0 || C > 100 || I < 0 || I > 100)
        {
            throw new ArgumentException("Please check the argument(s) passed.");
        }

        if (eafs == null)
        {
            throw new ArgumentNullException("Variable not initilized.");
        }

        float S = kloc * sizeEquivalent(DD, C, I) / 100;
        ResultSet r;

        try
        {
            r = Calculate(kloc, mode, eafs);
        }
        catch (Exception)
        {
            throw;
        }
        int i = 0;

        if (mode == 0 && S <= 32)
        {
            i = 0;
        }
        else if (mode == 0 && S > 32 && S <= 128)
        {
            i = 1;
        }
        else if (mode == 1 && S > 32 && S <= 128)
        {
            i = 2;
        }
        else if (mode == 1 && S > 128 && S <= 320)
        {
            i = 3;
        }
        else if (mode == 2 && S > 128 && S <= 320)
        {
            i = 4;
        }
        else if (mode == 2 && S > 320)
        {
            i = 5;
        }

        float[] m = new float[5], t = new float[5];

        for (int x = 0; x < 5; x++)
        {
            m[x] = _mu[i, x] * r.Effort;
            t[x] = _tau[i, x] * r.Duration;
        }

        return new DetailedResultSet(r, m, t);
    }

    #endregion

    #region Private Methods
    /// <summary>
    /// 
    /// </summary>
    /// <param name="DD"></param>
    /// <param name="C"></param>
    /// <param name="I"></param>
    /// <returns></returns>
    private static float sizeEquivalent(float DD, float C, float I)
    {
        return (float)(0.4 * DD + 0.3 * C + 0.3 * I);
    }
    #endregion

}
