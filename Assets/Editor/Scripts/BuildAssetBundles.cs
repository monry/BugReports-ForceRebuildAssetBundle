using UnityEditor;

public static class BuildAssetBundles
{
    [MenuItem("Project/Build AssetBundles")]
    public static void Run()
    {
        BuildPipeline.BuildAssetBundles(
            "Assets/AssetBundles/Standalone",
            BuildAssetBundleOptions.ForceRebuildAssetBundle,
            BuildTarget.StandaloneOSX
        );
    }
}