
namespace cocomo
{
    public class ResultSet
    {
        private float _effort;
        public float Effort
        {
            get
            {
                return _effort;
            }
        }

        private float _duration;
        public float Duration
        {
            get
            {
                return _duration;
            }
        }

        private float _avgStaffSize;
        public float AverageStaffSize
        {
            get
            {
                return _avgStaffSize;
            }
        }

        private float _productivity;
        public float Productivity
        {
            get
            {
                return _productivity;
            }
        }

        public ResultSet(float effort, float duration, float avgStaffSize, float productivity)
        {
            this._effort = effort;
            this._duration = duration;
            this._avgStaffSize = avgStaffSize;
            this._productivity = productivity;
        }

        public ResultSet(ResultSet r)
        {
            this._effort = r.Effort;
            this._duration = r.Duration;
            this._avgStaffSize = r.AverageStaffSize;
            this._productivity = r.Productivity;
        }

    }
}
