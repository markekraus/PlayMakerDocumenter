using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionParticleSystemPause(this StringBuilder sb, ParticleSystemPause action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ParticleSystemPause)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._ps), action._ps, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.playOnExit), action.playOnExit, ctx)
            .BuildTable();
}
