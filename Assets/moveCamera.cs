using UnityEngine;
using System;
public class WASDCameraController : MonoBehaviour
{
    public float speed = 35.0f;

    public float rotationSpeed = 30.0f;
    private Vector3 _movement;
    private Vector3 _rotation;

    private Vector3 startPosition, preset1, preset2, preset3; 

    void Start(){
        startPosition = this.transform.position;
        preset1 = new Vector3(0.0f, 0.0f, 0.0f);
        preset2 = new Vector3(-80.0f, -50.0f, 105.0f);
        preset3 = new Vector3(0.0f, -20.0f, 130.0f);
    }
    void Update()
    {
        _movement = Vector3.zero;
        //rotation transform

        if (Input.GetKey(KeyCode.W))
        {
            _movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _movement += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _movement += Vector3.right;
        }
        if (Input.GetKey(KeyCode.Space))
            //_movement += Vector3.forward * Math.Sin(alpha) ; //TODO
            _movement += Vector3.up;
        if (Input.GetKey(KeyCode.LeftControl))
            _movement += Vector3.down;
        
        if (Input.GetKey(KeyCode.Q))
            this.transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));

        if (Input.GetKey(KeyCode.E))
            this.transform.Rotate(new Vector3(0, -rotationSpeed * Time.deltaTime, 0));

        //if (Input.GetButtonDown("camReset")){
            //transform.position = startPosition;
        //}
        transform.Translate(_movement * speed * Time.deltaTime);
        Console.WriteLine(_movement);
    }

    public void resetPos(){ //changes camera's position to initial one
        
        this.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
        //this.transform.rotation = new Quaternion(0.0f, 180.00f, 0.0f); //some issues with the rotation
    }

    public void pos1(){ //change camera's position to preset 1
        this.transform.position = preset1;
    }

    public void pos2(){ //change camera's position to preset 2
        this.transform.position = preset2;
    }

    public void pos3(){//change camera's position to preset 3
        this.transform.position = preset3;
    }
    
}