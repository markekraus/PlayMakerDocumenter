using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ParticleSystemPlayDoc : FsmActionDoc
{
    internal ParticleSystemPlayDoc(ActionContext Ctx, ParticleSystemPlay action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.cacheChildren), action.cacheChildren);
        this.AddProperty(nameof(action.childParticleSystems), action.childParticleSystems);
        this.AddProperty(nameof(action.destroyOnFinish), action.destroyOnFinish);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.go), action.go);
        this.AddProperty(nameof(action.stopOnExit), action.stopOnExit);
        this.AddProperty(nameof(action.withChildren), action.withChildren);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ParticleSystemPlayDoc Document(this ActionContext ctx, ParticleSystemPlay Action) =>
        new(ctx, Action);
}
