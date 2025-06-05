using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ObjectDoc : FsmActionDoc
{
    internal ObjectDoc(ActionContext Ctx) : base(Ctx)
    {
        this.AddProperty("ToString", ctx.ActionCasted.ToString());
        DocumentationSupported = false;
    }
}

internal static partial class ActionContextExtensions
{
    public static ObjectDoc Document(this ActionContext ctx, object Action) =>
        new(ctx);
}