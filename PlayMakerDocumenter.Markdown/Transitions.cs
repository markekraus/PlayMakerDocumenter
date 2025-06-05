namespace PlayMakerDocumenter.Markdown;

internal static class Transitions
{
    internal static StringBuilder AddTransitions(this StringBuilder sb, TransitionsDoc doc, string header)
    {
        if (doc is null || sb is null) return sb;
        var tb = sb.AppendHeader(header)
            .NewTable()
            .WithHeaders("EventName", "ToFsmState");
        foreach (var item in doc)
        {
            tb.AddRow(item.Key, item.Value);
        }
        return tb.BuildTable();
    }
}