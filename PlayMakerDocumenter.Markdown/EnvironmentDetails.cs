namespace PlayMakerDocumenter.Markdown;

internal static class EnvironmentDetails
{
    private static readonly Lazy<IEnumerable<PropertyInfo>> propertyCache = new(GetProperties);
    private static IEnumerable<PropertyInfo> properties => propertyCache.Value;
    private static IEnumerable<PropertyInfo> GetProperties() =>
        typeof(EnvironmentDoc)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name);
    internal static StringBuilder AddEnvironmentDetails(this StringBuilder sb, EnvironmentDoc doc)
    {
        if (doc is null || sb is null) return sb;
        var tb = sb.AppendHeader("## Environment details")
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