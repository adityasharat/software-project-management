using System;

public sealed class WalstonFelixSEL : System.ComponentModel.Component
{
    // Constants for the SEL model
    private static float a = 1.4f;
    private static float b = 0.93f;
    private static float c = 30.4f;
    private static float d = 0.90f;
    private static float e = 4.6f;
    private static float f = 0.26f;

    // Constants for the Walston Felix Model
    private static float p = 5.2f;
    private static float q = 0.91f;
    private static float r = 4.1f;
    private static float s = 0.36f;

    /// <summary>
    /// This function calculates the results of the Walston and Felix model.
    /// </summary>
    /// <param name="L">Lines of Code.</param>
    /// <returns>Float Array as Effort Duration</returns>
    /// <exception cref="ArgumentException">This should be valid positive floating point value.</exception>
    public static float[] walstonFelix(float L)
    {
        if (L <= 0)
            throw new ArgumentException("Invalid Argument(s) passed.");

        float E = (float)(p * Math.Pow(L, q));
        float D = (float)(r * Math.Pow(L, s));

        return new float[] { E, D };
    }

    /// <summary>
    /// This function calculates the results of the SEL model
    /// </summary>
    /// <param name="L">Lines of Code.</param>
    /// <returns>Float Array as Effort Duration Doc </returns>
    /// <exception cref="ArgumentException">This should be valid positive floating point value.</exception>
    public static float[] SEL(float L)
    {
        if (L <= 0)
            throw new ArgumentException("Invalid Argument(s) passed.");

        float E = (float)(a * Math.Pow(L, b));
        float D = (float)(c * Math.Pow(L, d));
        float DOC = (float)(e * Math.Pow(L, f));

        return new float[] { E, D, DOC };
    }
}
