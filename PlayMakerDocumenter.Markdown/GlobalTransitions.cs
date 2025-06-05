namespace PlayMakerDocumenter.Markdown;

internal static class GlobalTransitions
{
    internal static StringBuilder AddGlobalTransitions(this StringBuilder sb, TransitionsDoc doc) =>
        sb is null
        ? sb
        : sb.AddTransitions(doc, "## Global Transitions");
}