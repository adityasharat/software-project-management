using System;

public sealed class Putnam : System.ComponentModel.Component
{
    #region Members

    private bool flagK;
    private bool flagTd;

    #endregion

    #region Properties
    private float K;
    public float TotalEffort
    {
        get
        {
            return K;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Invalid Argument(s) passed.");
            else
            {
                K = value;
                this.flagK = true;
                isSet();
            }
        }
    }

    private float td;
    public float TotalDuration
    {
        get
        {
            return td;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Invalid Argument(s) passed.");
            else
            {
                td = value;
                this.flagTd = true;
                isSet();
            }
        }
    }

    private double m0;
    public double PeakManning
    {
        get
        {
            return m0;
        }
    }

    private double D;
    public double DifficultyMetric
    {
        get
        {
            return D;
        }
    }

    private double D0;
    public double ManPowerBuildup
    {
        get
        {
            return D0;
        }
    }
    #endregion

    public double manpowerAt(float t)
    {
        if (t < 0 || t > td)
            throw new ArgumentException("Argument must be positive and less than the total duration: " + td);
        return this.K * (1 - Math.Pow(Math.E, -1 * (1 / (2 * (Math.Pow(td, 2))) * Math.Pow(t, 2))));
    }

    private void isSet()
    {
        if (this.flagK && this.flagTd)
        {
            this.m0 = (float)this.K / (this.td * Math.Pow(Math.E, 0.5));
            this.D = this.K / Math.Pow(this.td, 2);
            this.D0 = this.K / Math.Pow(this.td, 3);
        }
    }
}
