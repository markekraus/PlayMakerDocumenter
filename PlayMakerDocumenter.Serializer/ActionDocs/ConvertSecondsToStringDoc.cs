using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertSecondsToStringDoc : FsmActionDoc
{
    internal ConvertSecondsToStringDoc(ActionContext Ctx, ConvertSecondsToString action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.format), action.format);
        this.AddProperty(nameof(action.secondsVariable), action.secondsVariable);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertSecondsToStringDoc Document(this ActionContext ctx, ConvertSecondsToString Action) =>
        new(ctx, Action);
}
