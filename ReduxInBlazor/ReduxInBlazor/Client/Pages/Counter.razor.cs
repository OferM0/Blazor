using Fluxor;
using Microsoft.AspNetCore.Components;
using ReduxInBlazor.Client.Store.Counter;
using System;

namespace ReduxInBlazor.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        private IState<CounterState> CounterState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        private void IncrementCount()
        {
            var action = new IncrementCounterAction();
            Dispatcher.Dispatch(action);
        }

        // Handle StateChanged event 
        // rather than inherit FluxorComponent
        //protected override void OnAfterRender(bool firstRender)
        //{
        //    if (firstRender)
        //    {
        //        CounterState.StateChanged += StateChanged;
        //    }
        //}
        //public void StateChanged(object sender, EventArgs args)
        //{
        //    InvokeAsync(StateHasChanged);
        //}

        //void IDisposable.Dispose()
        //{
        //    CounterState.StateChanged -= StateChanged;
        //}
    }
}
