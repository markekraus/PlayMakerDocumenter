namespace PlayMakerDocumenter.Markdown;

internal static class FsmEvents
{
    internal static StringBuilder AddFsmEvents(this StringBuilder sb, FsmEventsDoc doc)
    {
        if (doc is null || sb is null) return sb;
        var tb = sb.AppendHeader("## Events")
            .NewTable()
            .WithHeaders("Name", "Path");
        foreach (var item in doc.OrderBy(e => e.Name))
        {
            tb.AddRow(item.Name, item.Path);
        }
        return tb.BuildTable();
    }
}