using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSingletonManager(this StringBuilder sb, SingletonManager action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SingletonManager)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
