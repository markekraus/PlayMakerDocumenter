using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionParticleSystemPlay(this StringBuilder sb, ParticleSystemPlay action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ParticleSystemPlay)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.cacheChildren), action.cacheChildren, ctx)
            .AddRow(nameof(action.childParticleSystems), action.childParticleSystems, ctx)
            .AddRow(nameof(action.destroyOnFinish), action.destroyOnFinish, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.go), action.go, ctx)
            .AddRow(nameof(action.stopOnExit), action.stopOnExit, ctx)
            .AddRow(nameof(action.withChildren), action.withChildren, ctx)
            .BuildTable();
}
