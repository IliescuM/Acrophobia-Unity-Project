using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementStage2 : MonoBehaviour
{
    PlayerMovement moveScript;

    public float dashSpeed;
    public float dashTime;

    void Start(){
        moveScript = GetComponent<PlayerMovement>();

    }
   
    void Update(){
        if(Input.GetKeyDown(KeyCode.LeftShift)){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;
            StartCoroutine(Dash(move));
        }
    }

    IEnumerator Dash(Vector3 move){
        float startTime = Time.time;
        
        while(Time.time <startTime + dashTime){
            moveScript.controller.Move(move * dashSpeed * Time.deltaTime);
        }
        yield return null;
    }
}
