namespace PlayMakerDocumenter.Serializer;

public record FsmActionDoc
{
    public FsmActionGeneralDetailsDoc GeneralDetails;
    public bool ActionTypeSupported;
    public FsmActionTypeDetails TypeDetails;
    internal ActionContext ctx;
    public FsmActionDoc() { }
    private FsmActionDoc(ActionContext Ctx)
    {
        ctx = Ctx;
        GeneralDetails = ctx;
        TypeDetails = new();
        ActionTypeSupported = false;
    }
    public static implicit operator FsmActionDoc(ActionContext Ctx) =>
        new(Ctx);
}
