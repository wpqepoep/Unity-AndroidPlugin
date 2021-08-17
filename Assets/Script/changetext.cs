using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changetext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextMesh textmesh = GetComponent<TextMesh>();
        var plugin = new AndroidJavaClass("com.top.plugin1.PluginClass");
        textmesh.text = plugin.CallStatic<string>("getString", 17);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
