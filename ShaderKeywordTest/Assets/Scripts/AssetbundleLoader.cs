using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetbundleLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/shader");
        bundle.LoadAsset<Shader>("TestShader");

        bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/blue");
        var prefab = bundle.LoadAsset<GameObject>("Blue");
        var blue = GameObject.Instantiate(prefab);
        blue.transform.position = Vector3.zero;

        bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/red");
        prefab = bundle.LoadAsset<GameObject>("Red");
        var red = GameObject.Instantiate(prefab);
        red.transform.position = new Vector3(1,0,0);

        bundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/green");
        prefab = bundle.LoadAsset<GameObject>("Green");
        var green = GameObject.Instantiate(prefab);
        green.transform.position = new Vector3(-1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
