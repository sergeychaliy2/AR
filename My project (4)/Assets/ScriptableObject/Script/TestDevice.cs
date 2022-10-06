using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDevice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var allDeviceInfo = Resources.LoadAll<Info>("");
        foreach (var startInfo in allDeviceInfo)
            Debug.Log(startInfo.id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
