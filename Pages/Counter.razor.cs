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
}