using System.Linq;

namespace Lab1
{
    public class FloatSequence : AbstractSequence<float>
    {
        public FloatSequence(float initialValue) : base(initialValue)
        {
        }
        
        public override void SetNextResult()
        {
            float x = Results.Last();
            float xPlusOne = x + 3 * x * (1-x);
            Results.Add(xPlusOne);
        }
    }
}