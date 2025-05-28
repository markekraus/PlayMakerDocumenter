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
                new string[] { nameof(reference), reference.FormatValue() })
            .AddRowIfNotNull(action.shufflingRange, shufflingRange =>
                new string[] { nameof(shufflingRange), shufflingRange.FormatValue() })
            .AddRowIfNotNull(action.startIndex, startIndex =>
                new string[] { nameof(startIndex), startIndex.FormatValue() })
            .BuildTable();
}
