using System.Linq;
using Lab1.Sequence.Base;

namespace Lab1.Sequence.FirstSequence
{
    public class DoubleSequence : AbstractSequence<double>
    {
        public DoubleSequence(double initialValue) : base(initialValue)
        {
        }

        public override void SetNextResult()
        {
            double x = Results.Last();
            double xPlusOne = x + 3 * x * (1-x);
            Results.Add(xPlusOne);
        }
    }
}