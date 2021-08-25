using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaw : MonoBehaviour
{
    bool isHasGyo = false;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        TextMesh textmesh = GetComponent<TextMesh>();
        if (SystemInfo.supportsGyroscope)
        { // 檢查手機是否有提供陀螺儀功能
            Input.gyro.enabled = true; // 啟用陀螺儀
            isHasGyo = true;
            textmesh.text = "Using Gyroscope";
        }
        else
        {
            textmesh.text = "Not using Gyroscope";
        }

    }

    // Update is called once per frame
    void Update()
    {
        TextMesh textmesh = GetComponent<TextMesh>();
        z = Input.gyro.attitude.eulerAngles.z;
        textmesh.text = "Yaw :  " + z ;
    }
}
