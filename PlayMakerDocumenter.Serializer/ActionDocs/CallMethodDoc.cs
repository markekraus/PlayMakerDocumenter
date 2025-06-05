using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record CallMethodDoc : FsmActionDoc
{
    internal CallMethodDoc(ActionContext Ctx, CallMethod action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.behaviour), action.behaviour);
        this.AddProperty(nameof(action.cachedBehaviour), action.cachedBehaviour);
        this.AddProperty(nameof(action.cachedMethodInfo), action.cachedMethodInfo);
        this.AddProperty(nameof(action.cachedMethodName), action.cachedMethodName);
        this.AddProperty(nameof(action.cachedParameterInfo), action.cachedParameterInfo);
        this.AddProperty(nameof(action.cachedType), action.cachedType);
        this.AddProperty(nameof(action.errorString), action.errorString);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.manualUI), action.manualUI);
        this.AddProperty(nameof(action.methodName), action.methodName);
        this.AddProperty(nameof(action.parameters), action.parameters);
        this.AddProperty(nameof(action.parametersArray), action.parametersArray);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static CallMethodDoc Document(this ActionContext ctx, CallMethod Action) =>
        new(ctx, Action);
}
