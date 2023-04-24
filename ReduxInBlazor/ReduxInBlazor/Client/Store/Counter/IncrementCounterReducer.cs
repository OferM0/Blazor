using Fluxor;

namespace ReduxInBlazor.Client.Store.Counter
{
	public class IncrementCounterReducer : Reducer<CounterState, IncrementCounterAction>
	{
		public override CounterState Reduce(CounterState state, IncrementCounterAction action)
		{
			return new CounterState(state.CurrentCount+action.Step);
		}
	}
}
