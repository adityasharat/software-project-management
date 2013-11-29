
namespace cocomo
{
    public class DetailedResultSet : ResultSet
    {
        private float[] _mu;
        public float[] Mu
        {
            get
            {
                return _mu;
            }
        }

        private float[] _tau;
        public float[] Tau
        {
            get
            {
                return _tau;
            }
        }

        public DetailedResultSet(ResultSet r, float[] mu, float[] tau)
            : base(r)
        {
            this._mu = mu;
            this._tau = tau;
        }
    }
}