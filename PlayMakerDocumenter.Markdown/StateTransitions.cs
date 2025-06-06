

namespace PlayMakerDocumenter.Markdown;

internal static class StateTransitions
{
    internal static StringBuilder AddStateTransitions(this StringBuilder sb, FsmStateDoc doc)
    {
        if (doc is null || sb is null || doc.Transitions.Count < 1) return sb;
        var tb = sb.AppendHeader($"### {doc.Details.StateIndex} {doc.Details.Name}: Transitions")
            .NewTable()
            .WithHeaders("EventName", "ToFsmState");
        foreach (var item in doc.Transitions)
        {
            tb.AddRow(item.Key, item.Value);
        }
        return tb.BuildTable();
    }
}