using System.Security.Cryptography;

namespace PlayMakerDocumenter.Markdown;

internal static class FsmStates
{
    internal static StringBuilder AddFsmStates(this StringBuilder sb, FsmStatesDoc doc)
    {
        if (sb is null || doc is null) return sb;
        foreach (var state in doc)
        {
            sb
                .AddStateDetails(state.Details)
                .AddStateTransitions(state)
                .AddStateActions(state);
        }
        return sb;
    }
}