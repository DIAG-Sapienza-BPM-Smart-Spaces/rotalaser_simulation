using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ChangeHeight : MonoBehaviour
{

    public Slider slider;
    public GameObject led;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
            led.transform.position = new Vector3(led.transform.position.x,
            slider.value, led.transform.position.z);
            
        
        
    }
}

