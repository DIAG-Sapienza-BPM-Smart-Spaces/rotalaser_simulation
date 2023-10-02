using System.Collections;
using System;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class rotate : MonoBehaviour
{   
    
    public TMP_InputField gameObjectUp, gameObjectDown, gameObjectRight, gameObjectLeft, gameObjectHeight;
    public Slider sliderUp, sliderDown, sliderRight, sliderLeft, sliderDirectionalLight;
    public GameObject stripUp, stripDown, stripLeft, stripRight;
    public Light directionalLight;

    //public light directionalLight;

    private float tempUp;
    //public InputField test;
    // Start is called before the first frame update
    //private Text textBoxUp; 
    void Start()
    {
        //textBoxUp= gameObjectUp.GetComponent<Text>();
        sliderDown.value = 0;
        sliderUp.value = 0;
        sliderLeft.value = 0;
        sliderRight.value = 0;
        gameObjectDown.text = "0";
        gameObjectUp.text = "0";
        gameObjectLeft.text = "0";
        gameObjectRight.text = "0";
        gameObjectHeight.text = "30";
    }



    // Update is called once per frame
    void Update()
    {
        gameObjectHeight.text = Math.Floor(transform.position.y) .ToString();
        
    }

    public void readInputUp(){
        try{
            int temp = int.Parse(gameObjectUp.text);
            stripUp.transform.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(temp,0,0)); 
            Debug.Log(gameObjectUp.text);
        }              
        catch(Exception e){
            gameObjectUp.text = "0";
        }
    }
    public void readInputDown(){
        try{
            int temp = int.Parse(gameObjectDown.text);
            stripDown.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(temp,0,0)); 
        }
        catch(Exception e){
            gameObjectDown.text = "0";
        }
    }

    public void readInputRight(){
        try{
            int temp = int.Parse(gameObjectRight.text);
            stripRight.transform.GetChild(0).transform.rotation = Quaternion.Euler(new Vector3(0,0,temp)); 
        }
        catch(Exception e){
            gameObjectRight.text = "0";
        }
    }
    public void readInputLeft(){
        try{
            int temp = int.Parse(gameObjectLeft.text);
            stripLeft.transform.GetChild(0).transform.localRotation = Quaternion.Euler(new Vector3(0,0,temp));
        }
        catch(Exception e){
            gameObjectLeft.text = "0";
        }
    }


    //this whole piece of could should be refactored to be a single function having the textbox as input parameter...

    public void increaseUp(){
        int number = int.Parse(gameObjectUp.text)+10;
        
        gameObjectUp.text = number.ToString();
        
    }
    public void decreaseUp(){
        int number = int.Parse(gameObjectUp.text)-10;
        
        gameObjectUp.text = number.ToString();
        Debug.Log(gameObjectUp.text);
    }

    public void increaseDown(){
        int number = int.Parse(gameObjectDown.text)+10;
        
        gameObjectDown.text = number.ToString();
        Debug.Log(gameObjectDown.text);
    }

    public void decreaseDown(){
        int number = int.Parse(gameObjectDown.text)-10;
        
        gameObjectDown.text = number.ToString();
        Debug.Log(gameObjectDown.text);

    }
    public void increaseRight(){
        int number = int.Parse(gameObjectRight.text)+10;
        
        gameObjectRight.text = number.ToString();
        Debug.Log(gameObjectRight.text);
    }

    public void decreaseRight(){
        int number = int.Parse(gameObjectRight.text)-10;
        
        gameObjectRight.text = number.ToString();
        Debug.Log(gameObjectRight.text);   
    }


    public void increaseLeft(){
        int number = int.Parse(gameObjectLeft.text)+10;
        
        gameObjectLeft.text = number.ToString();
        Debug.Log(gameObjectLeft.text);
    }

    public void decreaseLeft(){
        int number = int.Parse(gameObjectLeft.text)-10;
        
        gameObjectLeft.text = number.ToString();
        Debug.Log(gameObjectLeft.text);
    }

    public void increaseHeight(){
       int number = int.Parse(gameObjectHeight.text)+5;
        
        gameObjectHeight.text = number.ToString();
        Debug.Log(gameObjectHeight.text);
    }

    public void decreaseHeight(){
        int number = int.Parse(gameObjectHeight.text)-5;
        
        gameObjectHeight.text = number.ToString();
        Debug.Log(gameObjectHeight.text);
    }

    public void reset(){
        this.Start();
    }

    public void onChangeUp(){
        
        this.stripUp.transform.GetChild(0).transform.localPosition =  new Vector3(0,sliderUp.value,0);
       Debug.Log(stripUp.transform.GetChild(0).transform.localPosition);
    }
    public void onChangeDown(){
        this.stripDown.transform.GetChild(0).transform.localPosition =  new Vector3(0,sliderDown.value,0);
         Debug.Log(stripDown.transform.GetChild(0).transform.localPosition);
    }
    public void onChangeLeft(){
        this.stripLeft.transform.GetChild(0).transform.localPosition =  new Vector3(0,sliderLeft.value,0);
        
         Debug.Log(stripLeft.transform.GetChild(0).transform.localPosition);
    }
    public void onChangeRight(){
        this.stripRight.transform.GetChild(0).transform.localPosition =  new Vector3(0,sliderRight.value,0);
         Debug.Log(stripRight.transform.GetChild(0).transform.localPosition);
    }


    public void onChangeBackLight(){
            directionalLight.intensity = sliderDirectionalLight.value;
    }

    //this function set camera height
    public void onChangeHeight(){
       
         Vector3 camPos = this.transform.position;
        camPos.y = Int16.Parse(gameObjectHeight.text);

        this.gameObject.transform.position = camPos;
        
    }


    


}
