using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionHashTableValues(this StringBuilder sb, HashTableValues action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(HashTableValues)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.arrayListGameObject), action.arrayListGameObject, ctx)
            .AddRow(nameof(action.arrayListReference), action.arrayListReference, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
