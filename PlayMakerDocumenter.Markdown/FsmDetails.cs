namespace PlayMakerDocumenter.Markdown;

internal static class FsmDetails
{
    private static readonly Lazy<IEnumerable<PropertyInfo>> propertyCache = new(GetProperties);
    private static IEnumerable<PropertyInfo> properties => propertyCache.Value;
    private static IEnumerable<PropertyInfo> GetProperties() =>
        typeof(FsmDetailsDoc)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
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