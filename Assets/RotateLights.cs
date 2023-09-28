using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLights : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] lightArray;
    void Start()
    {
        lightArray = GameObject.FindGameObjectsWithTag("Light");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lightArray.Length; i++) {
            lightArray[i].transform.Rotate(0,5,0);
        }
        
    }
}
