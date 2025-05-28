using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    private static StringBuilder DocActionArrayListShuffle(this StringBuilder sb, ArrayListShuffle action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListShuffle)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.reference, reference =>
                new string[] { "reference", $"{reference.Value}" })
            .AddRowIfNotNull(action.shufflingRange, shufflingRange =>
                new string[] { "shufflingRange", $"{shufflingRange.Value}" })
            .AddRowIfNotNull(action.startIndex, startIndex =>
                new string[] { "shufflingRange", $"{startIndex.Value}" })
            .BuildTable();
}
