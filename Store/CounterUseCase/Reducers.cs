public static class Reducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action)
    {
        return new CounterState(clickCount: state.ClickCount + 1);
    }
}