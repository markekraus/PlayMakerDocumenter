namespace PlayMakerDocumenter.Markdown;

internal static class SateActions
{
    internal static StringBuilder AddStateActions(this StringBuilder sb, FsmStateDoc doc)
    {
        if (sb is null || doc is null) return sb;
        sb.AppendHeader($"### {doc.Details.StateIndex} {doc.Details.Name}: Actions");
        foreach (var action in doc.Actions)
        {
            sb
                .AppendHeader($"#### Action: {action.GeneralDetails.StateIndex}-{action.GeneralDetails.ActionIndex} {action.GeneralDetails.Name}")
                .AddStateActionGeneralDetails(action)
                .AddStateActionTypeDetails(action);
        }
        return sb;
    }
}