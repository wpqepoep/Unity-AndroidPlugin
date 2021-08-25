using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatio : MonoBehaviour
{
    
    public float x, y, z;
    
    // Start is called before the first frame update
    void Start()
    {
        var plugin = new AndroidJavaClass("com.top.plugin1.PluginClass");
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }

    }

    // Update is called once per frame
    void Update()
    {       
        if (SystemInfo.supportsGyroscope)
            transform.rotation = GyroToUnity(Input.gyro.attitude);
       
    }
    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}
