namespace PlayMakerDocumenter.Markdown;

internal static class GlobalTransitions
{
    internal static StringBuilder AddGlobalTransitions(this StringBuilder sb, TransitionsDoc doc)
    {
        if (doc is null || sb is null || doc.Count < 1) return sb;
        var tb = sb.AppendHeader("## Global Transitions")
            .NewTable()
            .WithHeaders("EventName", "ToFsmState");
        foreach (var item in doc)
        {
            tb.AddRow(item.Key, item.Value);
        }
        return tb.BuildTable();
    }
}