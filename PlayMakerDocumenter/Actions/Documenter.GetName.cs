using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetName(this StringBuilder sb, GetName action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetName)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.storeName), action.storeName, ctx)
            .BuildTable();
}
