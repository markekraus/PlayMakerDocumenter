namespace PlayMakerDocumenter.Serializer;

public record FsmActionDoc
{
    public FsmActionGeneralDetailsDoc GeneralDetails;
    public FsmActionTypeDetails TypeDetails;
    public bool DocumentationSupported;
    internal ActionContext ctx;
    public FsmActionDoc() { }
    private FsmActionDoc(ActionContext Ctx)
    {
        ctx = Ctx;
        GeneralDetails = ctx;
        TypeDetails = new();
        DocumentationSupported = false;
    }
    public static implicit operator FsmActionDoc(ActionContext Ctx) =>
        new(Ctx);
}
