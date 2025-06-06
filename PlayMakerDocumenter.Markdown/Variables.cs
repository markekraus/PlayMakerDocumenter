namespace PlayMakerDocumenter.Markdown;

internal static class Variables
{
    internal static StringBuilder AddVariables(this StringBuilder sb, FsmVariablesDoc doc)
    {
        if (doc is null || sb is null || doc.Count < 1) return sb;
        var tb = sb.AppendHeader("## Variables")
            .NewTable()
            .WithHeaders("Name", "Value", "Type");
        foreach (var item in doc.OrderBy(v => v.Name))
        {
            tb.AddRow(item.Name, item.Value, item.Type);
        }
        return tb.BuildTable();
    }
}