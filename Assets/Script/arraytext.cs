using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraytext : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objectslect;
    public int currentobject;
    void Start()
    {
        for (var i = 0; i < objectslect.Length; i++){
            if (objectslect[i].activeSelf)
            {
                currentobject = i;
            }
        }
        objectslect[currentobject].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayNextObject()
    {
        objectslect[0].SetActive(false);
        objectslect[1].SetActive(false);
        objectslect[2].SetActive(false);
        objectslect[3].SetActive(false);
        objectslect[4].SetActive(false);
        objectslect[5].SetActive(false);
        currentobject++;
        if (currentobject > objectslect.Length-1)
        {
            currentobject = 0;
        }
        objectslect[currentobject].SetActive(true);
    }
}
