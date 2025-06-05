namespace PlayMakerDocumenter.Markdown;

internal static class StateActionTypeDetails
{
    internal static StringBuilder AddStateActionTypeDetails(this StringBuilder sb, FsmActionDoc doc)
    {
        if (doc is null || sb is null) return sb;
        var tb = sb.AppendHeader($"{doc.GeneralDetails.Type} Details:")
            .NewTable()
            .WithNameValueHeaders();
        foreach (var item in doc.TypeDetails.OrderBy(d => d.Property))
        {
            tb.AddRow(item.Property, item.Value);
        }
        return tb.BuildTable();
    }
}