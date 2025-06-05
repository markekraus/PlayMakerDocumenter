using Il2Cpp;
using UnityEngine;

namespace PlayMakerDocumenter.Serializer;

public class EnvironmentDoc
{
    public string ProductName;
    public string CompanyName;
    public string Version;
    public string BuildGUID;
    public string UnityVersion;
    public string PlayMakerAssemblyVersion;
    public EnvironmentDoc()
    {
        ProductName = Application.productName;
        CompanyName = Application.companyName;
        Version = Application.version;
        BuildGUID = Application.buildGUID;
        UnityVersion = Application.unityVersion;
        PlayMakerAssemblyVersion = typeof(PlayMakerFSM).Assembly.GetName().Version.ToString();
    }
}