[FeatureState]
public class CounterState
{
    public int ClickCount { get; } // Read-only property, set when instantiated by the reducer
    private CounterState() { } // Required for creating initial state
    public CounterState(int clickCount)
    {
        ClickCount = clickCount;
    }
}