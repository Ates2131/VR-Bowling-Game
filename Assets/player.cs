﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Transform vrPlayer;
    public float lookDownAngle = 15.0f;
    public float speed = 3.0f;
    //Grab obj = new Grab();
    //&&obj.canGrab==false
    public bool moveForward;
    private 
    CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
      if(vrPlayer.eulerAngles.x >= lookDownAngle && vrPlayer.eulerAngles.x<90.0f ){
        moveForward = true;
      }else{
        moveForward = false;
      }
      if(moveForward==true){
        Vector3 forward = vrPlayer.TransformDirection(Vector3.forward);
        cc.SimpleMove(forward * speed);
      }  
    }
}