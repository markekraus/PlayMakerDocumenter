using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGameObjectIsNull(this StringBuilder sb, GameObjectIsNull action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GameObjectIsNull)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.isNotNull), action.isNotNull, ctx)
            .AddRow(nameof(action.isNull), action.isNull, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
