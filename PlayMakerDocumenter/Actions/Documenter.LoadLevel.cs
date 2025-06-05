using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionLoadLevel(this StringBuilder sb, LoadLevel action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(LoadLevel)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.additive), action.additive, ctx)
            .AddRow(nameof(action.async), action.async, ctx)
            .AddRow(nameof(action.asyncOperation), action.asyncOperation, ctx)
            .AddRow(nameof(action.dontDestroyOnLoad), action.dontDestroyOnLoad, ctx)
            .AddRow(nameof(action.failedEvent), action.failedEvent, ctx)
            .AddRow(nameof(action.levelName), action.levelName, ctx)
            .AddRow(nameof(action.loadedEvent), action.loadedEvent, ctx)
            .BuildTable();
}
