using System.Linq;

namespace Lab1
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