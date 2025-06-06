namespace PlayMakerDocumenter.Markdown;

internal static class FsmDetails
{
    private static readonly Lazy<IEnumerable<FieldInfo>> propertyCache = new(GetProperties);
    private static IEnumerable<FieldInfo> properties => propertyCache.Value;
    private static IEnumerable<FieldInfo> GetProperties() =>
        typeof(FsmDetailsDoc)
            .GetFields(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name);

    internal static StringBuilder AddFsmDetails(this StringBuilder sb, FsmDetailsDoc doc)
    {
        if (doc is null || sb is null) return sb;
        var tb = sb.AppendHeader("## FSM Details")
            .NewTable()
            .WithPropertyValueHeaders();
        foreach (var prop in properties)
        {
            var value = prop.GetValue(doc);
            tb.AddRow(prop.Name, $"{value}");
        }
        return tb.BuildTable();
    }
}