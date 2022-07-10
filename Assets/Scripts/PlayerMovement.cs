using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.04f;
    public float jumpHeight = 0.3f;
    public LayerMask groundMask;
    public AudioSource source;
    
    
    public AudioClip jumpsound;
    //public AudioClip walksound;
    

    bool isGrounded;
    Vector3 velocity;
     void Start() {
        gameObject.tag = "Player";
        AudioSource[] audioSource = GetComponents<AudioSource>();
        source = audioSource[0];
        jumpsound = audioSource[0].clip;
        //walksound = audioSource[1].clip;

    }
    

    // Update is called once per frame
    void Update()
    {   
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);

        if(isGrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        Vector3 move = transform.right * x + transform.forward * z;
        
        controller.Move(move * speed * Time.deltaTime);
        

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y=Mathf.Sqrt(jumpHeight *-2f * gravity);
            source.PlayOneShot(jumpsound);
        
        }
        velocity.y += gravity * Time.deltaTime;


        controller.Move(velocity* Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
           // source.PlayOneShot(walksound);

        }

    }

    
}
