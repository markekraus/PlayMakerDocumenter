using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetOwner(this StringBuilder sb, GetOwner action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetOwner)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.storeGameObject), action.storeGameObject, ctx)
            .BuildTable();
}
