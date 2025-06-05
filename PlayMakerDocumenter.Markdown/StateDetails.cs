namespace PlayMakerDocumenter.Markdown;

internal static class StateDetails
{
    private static readonly Lazy<IEnumerable<PropertyInfo>> propertyCache = new(GetProperties);
    private static IEnumerable<PropertyInfo> properties => propertyCache.Value;
    private static IEnumerable<PropertyInfo> GetProperties() =>
        typeof(FsmStateDetailsDoc)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name);

    internal static StringBuilder AddStateDetails(this StringBuilder sb, FsmStateDetailsDoc doc)
    {
        if (doc is null || sb is null) return sb;
        var tb = sb.AppendHeader($"## State {doc.StateIndex}: {doc.Name}")
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