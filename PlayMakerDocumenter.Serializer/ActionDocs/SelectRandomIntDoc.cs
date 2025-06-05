using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SelectRandomIntDoc : FsmActionDoc
{
    internal SelectRandomIntDoc(ActionContext Ctx, SelectRandomInt action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.ints), action.ints);
        this.AddProperty(nameof(action.storeInt), action.storeInt);
        this.AddProperty(nameof(action.weights), action.weights);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SelectRandomIntDoc Document(this ActionContext ctx, SelectRandomInt Action) =>
        new(ctx, Action);
}
