using GameFramework;
using System.IO;
using UnityEngine;
using UnityGameFramework.Editor;
using UnityGameFramework.Editor.ResourceTools;

public static class GameFrameworkConfigs
{
    [BuildSettingsConfigPath]
    public static string BuildSettingsConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "3rd/GameFramework/Configs/BuildSettings.xml"));

    [ResourceCollectionConfigPath]
    public static string ResourceCollectionConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "3rd/GameFramework/Configs/ResourceCollection.xml"));

    [ResourceEditorConfigPath]
    public static string ResourceEditorConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "3rd/GameFramework/Configs/ResourceEditor.xml"));

    [ResourceBuilderConfigPath]
    public static string ResourceBuilderConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "3rd/GameFramework/Configs/ResourceBuilder.xml"));
}
