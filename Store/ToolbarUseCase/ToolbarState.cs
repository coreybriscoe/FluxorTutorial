[FeatureState]
public class ToolbarState
{
    public string Message { get; }
    public bool Enabled { get; }
    public ToolbarState() { } // It can be public or private, but it must exist
    public ToolbarState(string message, bool enabled)
    {
        Message = message;
        Enabled = enabled;
    }
}