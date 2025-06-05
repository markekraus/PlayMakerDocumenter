using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionHashTableKeys(this StringBuilder sb, HashTableKeys action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(HashTableKeys)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.arrayListGameObject), action.arrayListGameObject, ctx)
            .AddRow(nameof(action.arrayListReference), action.arrayListReference, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
