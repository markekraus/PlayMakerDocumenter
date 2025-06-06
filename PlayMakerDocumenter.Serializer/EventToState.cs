namespace PlayMakerDocumenter.Serializer;

public record EventToState
{
    public string EventName;
    public string ToState;
    public EventToState() { }
    public EventToState(string EventName, string ToState) =>
        (this.EventName, this.ToState) =
        (EventName, ToState);
}