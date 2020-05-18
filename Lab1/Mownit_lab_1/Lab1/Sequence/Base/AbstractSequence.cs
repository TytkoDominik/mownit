using System.Collections.Generic;

namespace Lab1.Sequence.Base
{
    public abstract class AbstractSequence<T> where T : unmanaged
    {
        protected List<T> Results = new List<T>();

        public List<T> GetResults()
        {
            return Results;
        }
        
        public AbstractSequence(T initialValue)
        {
            Results.Add(initialValue);
        }
        
        public abstract void SetNextResult();

        public void SetNextResults(int count)
        {
            for (int i = 0; i < count; i++)
            {
                SetNextResult();
            }
        }
    }
}