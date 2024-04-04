public class SetEnabledAction
{
    public bool Enabled { get; }
    public SetEnabledAction() { }
    public SetEnabledAction(bool enabled)
    {
        Enabled = enabled;
    }
}