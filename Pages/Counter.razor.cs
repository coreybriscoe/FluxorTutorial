using Microsoft.AspNetCore.Components;
// Namespace statement required for code-behind file to be recognized
namespace FluxorTutorial.Pages.Counter;

partial class Counter
{
    [Inject]
    private IState<CounterState> CounterState { get; set; }

    [Inject]
    public IDispatcher Dispatcher { get; set; }

    public void IncrementCount()
    {
        Dispatcher.Dispatch(new IncrementCounterAction());
    }

    // These three are (always) used for the IDisposable implementation pattern instead of inheriting from FluxorComponent
    // This is just an example -- it is of course redundant because Counter is already the only one mutating this state
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            // Add event handler
            CounterState.StateChanged += StateChanged;
        }
    }

    // Event handler
    public void StateChanged(object sender, EventArgs args)
    {
        InvokeAsync(StateHasChanged);
    }

    // Prevent leaking memory by unhooking event handler
    void IDisposable.Dispose()
    {
        CounterState.StateChanged -= StateChanged;
    }
}