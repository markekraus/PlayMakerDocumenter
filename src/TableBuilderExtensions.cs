using UnityEngine;

namespace PlayMakerDocumenter;

internal static class TableBuilderExtensions
{
    public static TableBuilder AddRow(this TableBuilder tb, string Property, GameObject Value) =>
        tb.AddRowIfNotNull(Value, value => new string[] { Property, value.GetFullPath() });
}