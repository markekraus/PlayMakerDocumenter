using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertFloatToStringDoc : FsmActionDoc
{
    internal ConvertFloatToStringDoc(ActionContext Ctx, ConvertFloatToString action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        this.AddProperty(nameof(action.format), action.format);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertFloatToStringDoc Document(this ActionContext ctx, ConvertFloatToString Action) =>
        new(ctx, Action);
}
