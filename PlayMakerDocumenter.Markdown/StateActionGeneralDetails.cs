namespace PlayMakerDocumenter.Markdown;

internal static class StateActionGeneralDetails
{
    private static readonly Lazy<IEnumerable<FieldInfo>> propertyCache = new(GetProperties);
    private static IEnumerable<FieldInfo> properties => propertyCache.Value;
    private static IEnumerable<FieldInfo> GetProperties() =>
        typeof(FsmActionGeneralDetailsDoc)
            .GetFields(BindingFlags.Public | BindingFlags.Instance)
            .OrderBy(p => p.Name);
    internal static StringBuilder AddStateActionGeneralDetails(this StringBuilder sb, FsmActionGeneralDetailsDoc doc)
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