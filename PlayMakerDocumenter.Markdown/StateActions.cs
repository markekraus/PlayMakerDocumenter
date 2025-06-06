namespace PlayMakerDocumenter.Markdown;

internal static class SateActions
{
    internal static StringBuilder AddStateActions(this StringBuilder sb, FsmStateDoc doc)
    {
        if (sb is null || doc is null) return sb;
        sb.AppendHeader($"### {doc.Details.StateIndex} {doc.Details.Name}: Actions");
        foreach (var action in doc.Actions)
        {
            var details = action.GeneralDetails;
            sb
                .AppendHeader($"#### Action: {details.StateIndex}-{details.ActionIndex} {details.TypeName}")
                .AddStateActionGeneralDetails(details)
                .AddStateActionTypeDetails(action);
        }
        return sb;
    }
}