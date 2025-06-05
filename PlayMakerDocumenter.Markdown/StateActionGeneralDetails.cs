namespace PlayMakerDocumenter.Markdown;

internal static class StateActionGeneralDetails
{
    private static readonly Lazy<IEnumerable<PropertyInfo>> propertyCache = new(GetProperties);
    private static IEnumerable<PropertyInfo> properties => propertyCache.Value;
    private static IEnumerable<PropertyInfo> GetProperties() =>
        typeof(FsmStateDetailsDoc)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name);
    internal static StringBuilder AddStateActionGeneralDetails(this StringBuilder sb, FsmActionDoc doc)
    {
        if (sb is null || doc is null) return sb;
        var tb = sb
            .AppendHeader("General Action Details:")
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