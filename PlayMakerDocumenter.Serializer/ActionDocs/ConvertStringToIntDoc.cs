using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertStringToIntDoc : FsmActionDoc
{
    internal ConvertStringToIntDoc(ActionContext Ctx, ConvertStringToInt action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertStringToIntDoc Document(this ActionContext ctx, ConvertStringToInt Action) =>
        new(ctx, Action);
}
