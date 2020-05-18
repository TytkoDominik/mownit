using System.Linq;
using Lab1.Sequence.Base;

namespace Lab1.Sequence.AlteredSequence
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