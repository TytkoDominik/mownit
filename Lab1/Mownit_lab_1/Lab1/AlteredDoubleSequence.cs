using System.Linq;

namespace Lab1
{
    public class AlteredDoubleSequence : AbstractSequence<double>
    {
        public AlteredDoubleSequence(double initialValue) : base(initialValue)
        {
        }

        public override void SetNextResult()
        {
            double x = Results.Last();
            double xPlusOne = 4 * x - 3 * x * x;
            Results.Add(xPlusOne);
        }
    }
}