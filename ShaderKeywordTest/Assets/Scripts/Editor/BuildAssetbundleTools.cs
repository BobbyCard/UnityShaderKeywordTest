using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildAssetbundleTools
{
    [MenuItem("Tools/Build Assetbundle")]
    public static void BuildAssetbundle()
    {
        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath,BuildAssetBundleOptions.None,BuildTarget.Android);
    }
}
