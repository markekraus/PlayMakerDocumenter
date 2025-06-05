namespace PlayMakerDocumenter.Serializer;

public record FsmActionProperty
{
    public string Property;
    public string Value;
    public FsmActionProperty() {}
    public FsmActionProperty(string Property, string Value) =>
        (this.Property, this.Value) = (Property, Value);
    public FsmActionProperty(FsmVariableDoc fsmVar) =>
        (Property, Value) = (fsmVar.Name, fsmVar.Value);
    public static implicit operator FsmActionProperty(FsmVariableDoc fsmVar) =>
        new(fsmVar);
}