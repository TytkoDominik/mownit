using System.Linq;
using Lab1.Sequence.Base;

namespace Lab1.Sequence.AlteredSequence
{
    public class AlteredFloatSequence : AbstractSequence<float>
    {
        public AlteredFloatSequence(float initialValue) : base(initialValue)
        {
        }

        public override void SetNextResult()
        {
            float x = Results.Last();
            float xPlusOne = 4 * x - 3 * x * x;
            Results.Add(xPlusOne);
        }
    }
}