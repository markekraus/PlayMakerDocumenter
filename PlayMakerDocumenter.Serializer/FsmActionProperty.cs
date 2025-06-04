namespace PlayMakerDocumenter.Serializer;

public record FsmActionProperty(string Property, string Value)
{
    public FsmActionProperty(FsmVariableDoc fsmVar) : this(fsmVar.Name, fsmVar.Value) { }
    public static implicit operator FsmActionProperty(FsmVariableDoc fsmVar) =>
        new(fsmVar);
}