namespace PlayMakerDocumenter.Serializer;

public record FsmStateDetailsDoc(string Name, int StateIndex, string Description, bool HandlesOnEvent, int MaxLoopCount)
{
    public static implicit operator FsmStateDetailsDoc(FsmStateDoc state) =>
        new(state.state.Name, state.StateIndex, state.state.Description, state.state.HandlesOnEvent, state.state.maxLoopCount);
}