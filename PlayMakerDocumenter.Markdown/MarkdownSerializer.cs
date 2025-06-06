namespace PlayMakerDocumenter.Markdown;

public static class MarkdownSerializer
{
    public static StringBuilder SerializeMarkdown(this FsmDoc fsmDoc)
    {
        var sb = new StringBuilder();
        sb
            .AppendHeader($"# {fsmDoc.FsmDetails.FullPath}")
            .AddEnvironmentDetails(fsmDoc.EnvironmentDetails)
            .AddFsmDetails(fsmDoc.FsmDetails)
            .AddGlobalTransitions(fsmDoc.GlobalTransitions)
            .AddVariables(fsmDoc.Variables)
            .AddFsmEvents(fsmDoc.Events)
            .AddFsmStates(fsmDoc.States)
            ;
        return sb;
    }
}