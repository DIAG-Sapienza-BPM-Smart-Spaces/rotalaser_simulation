using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageLight : MonoBehaviour
{

    public GameObject LightStrip;
    public Slider slider;
    private List<Light> lights = new List<Light>(); //a collection of all lights
    // Start is called before the first frame update
    void Start()
    {

    foreach (Transform child in LightStrip.transform)
{
    // If the child is a Light, add it to the list.
    if (child.gameObject.GetComponent<Light>())
    {
        lights.Add(child.gameObject.GetComponent<Light>());
        Console.WriteLine(child.gameObject.name + "\n");
    }
}
    }

    // Update is called once per frame
    void Update()
    {
        dimLight();
    }


    public void turnOff(){
        if (lights[0].enabled){
        foreach (Light light in lights){
            light.enabled = false;
        }
        }
        else
            foreach (Light light in lights)
                light.enabled=true;
    }

    public void dimLight(){
        foreach (Light light in lights){
            light.intensity =  slider.value;
            //light.intensity = 1647099;
            
        }

    }
}