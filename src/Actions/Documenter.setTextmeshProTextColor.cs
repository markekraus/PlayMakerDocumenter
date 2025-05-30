using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionsetTextmeshProTextColor(this StringBuilder sb, setTextmeshProTextColor action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(setTextmeshProTextColor)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.meshproScript), action.meshproScript, ctx)
            .AddRow(nameof(action.textColor), action.textColor, ctx)
            .BuildTable();
}
