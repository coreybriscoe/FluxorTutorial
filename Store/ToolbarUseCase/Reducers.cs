namespace FluxorTutorial.Store.ToolbarUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static ToolbarState ReduceSetMessageAction(ToolbarState state, SetMessageAction action)
    {
        return new ToolbarState(message: action.Message, enabled: state.Enabled);
    }

    [ReducerMethod]
    public static ToolbarState ReduceSetEnabledAction(ToolbarState state, SetEnabledAction action)
    {
        return new ToolbarState(message: state.Message, enabled: action.Enabled);
    }
}