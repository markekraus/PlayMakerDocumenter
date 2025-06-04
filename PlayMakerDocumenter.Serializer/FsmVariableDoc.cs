using System.Collections.Generic;
using System.Linq;

namespace PlayMakerDocumenter.Serializer;

public record FsmVariableDoc(string Name, string Type, string Value);

internal static class FsmVariableDocExtensions
{
    public static IEnumerable<FsmActionProperty> ConvertToActionProperty(this IEnumerable<FsmVariableDoc> list) =>
        list.Select(fsmVar => (FsmActionProperty)fsmVar);
}