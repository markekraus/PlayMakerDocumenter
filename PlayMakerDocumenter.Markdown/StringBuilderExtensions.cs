namespace PlayMakerDocumenter.Markdown;

internal static class StringBuilderExtensions
{
    internal static StringBuilder AppendHeader(this StringBuilder sb, string header) =>
        sb.AppendLine(header).AppendLine("");
}