using Fluxor;

namespace ReduxInBlazor.Client.Store.Counter
{
    //[FeatureState]
	public class CounterState
	{
		public int CurrentCount { get; }
        private CounterState() { }
        public CounterState(int currentCount) { CurrentCount = currentCount; }
    }
}
