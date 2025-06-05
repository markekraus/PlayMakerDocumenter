using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionRandomEvent(this StringBuilder sb, RandomEvent action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(RandomEvent)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.delay), action.delay, ctx)
            .AddRow(nameof(action.delayedEvent), action.delayedEvent, ctx)
            .AddRow(nameof(action.lastEventIndex), action.lastEventIndex, ctx)
            .AddRow(nameof(action.noRepeat), action.noRepeat, ctx)
            .AddRow(nameof(action.randomEventIndex), action.randomEventIndex, ctx)
            .BuildTable();
}
