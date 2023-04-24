﻿using Fluxor;

namespace ReduxInBlazor.Client.Store.Counter
{
	public class CounterFeature : Feature<CounterState>
	{
		public override string GetName() => "Counter";

		protected override CounterState GetInitialState() => new CounterState(0);
	}
}
