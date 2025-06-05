namespace PlayMakerDocumenter.Markdown;

internal static class Variables
{
    internal static StringBuilder AddVariables(this StringBuilder sb, FsmVariablesDoc doc)
    {
        if (doc is null || sb is null) return sb;
        var tb = sb.AppendHeader("## Variables")
            .NewTable()
            .WithHeaders("Name", "Type", "Value");
        foreach (var item in doc.OrderBy(v => v.Name))
        {
            tb.AddRow(item.Name, item.Type, item.Value);
        }
        return tb.BuildTable();
    }
}