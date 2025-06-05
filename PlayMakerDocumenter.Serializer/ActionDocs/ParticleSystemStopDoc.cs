using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ParticleSystemStopDoc : FsmActionDoc
{
    internal ParticleSystemStopDoc(ActionContext Ctx, ParticleSystemStop action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._ps), action._ps);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.playOnExit), action.playOnExit);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ParticleSystemStopDoc Document(this ActionContext ctx, ParticleSystemStop Action) =>
        new(ctx, Action);
}
