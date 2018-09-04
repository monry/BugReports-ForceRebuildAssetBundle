# BugReports / ForceRebuildAssetBundle

Sample project for bug reporting about ForceRebuildAssetBundle option to Unity Technologies

## What's happen

* AssetBundle will not be updated, even if AssetBundles are built with the ForceRebuildAssetBundle option set.

## How to reproduce

1. Run `Project > Build AssetBundles` from menu bar
1. There is no change in the files under the `Assets/AssetBundles/Standalone/` directory.
    * Build script specifies `Assets/AssetBundles/Standalone/` directory to outputPath.
