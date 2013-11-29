using System;

public sealed class CocomoII : System.ComponentModel.Component
{
    #region Properties
    private static int[,] _weights = {
            {1,2,3},
            {2,5,8}
        };
    public static int[,] Weights
    {
        get
        {
            return _weights;
        }
    }

    private static int _3glWeight = 10;
    public static int ThreeGLWeight
    {
        get
        {
            return _3glWeight;
        }
    }

    #endregion

    #region Public Mthods

    /// <summary>
    /// This function calculates and returns the new Objects Points based on CocomoII
    /// </summary>
    /// <param name="screens">Array representing the number of simple, medium and difficult screens.</param>
    /// <param name="reports">Array representing the number of simple, medium and difficult reports.</param>
    /// <param name="_3gl">Number of 3GL components</param>
    /// <param name="reuse">% of reuse of objects</param>
    /// <returns>ResultSet that encapsulates all the results.</returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public static double ObjectPoints(int[] screens, int[] reports, int _3gl, float reuse)
    {
        if (screens == null || reports == null)
            throw new ArgumentNullException("Argument cannot be null.");

        if (screens.Length != 3 || reports.Length != 3 || reuse > 100 || reuse < 0 || _3gl < 0)
            throw new ArgumentException("Invalid Argument(s) passed.");

        float objectPoints = 0;

        // compute weighted sum of screens and reports
        for (int i = 0; i < 3; i++)
        {
            objectPoints += _weights[0, i] * screens[i] + _weights[1, i] * reports[i];
        }

        // add object points of 3GL components
        objectPoints += _3gl * _3glWeight;

        // calculate new Object points;
        objectPoints = objectPoints * ((100 - reuse) / 100);

        return objectPoints;
    }

    #endregion
}