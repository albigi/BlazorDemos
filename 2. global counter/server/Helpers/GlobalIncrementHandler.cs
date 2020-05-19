using System;

namespace server
{
    public class GlobalIncrementHandler
    {
        public Action OnIncrement {get;set;}
        public void Increment(ref int i)
        {
            System.Threading.Interlocked.Increment(ref i);
            OnIncrement?.Invoke();
        }
    }
}