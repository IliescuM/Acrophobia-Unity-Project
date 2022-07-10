using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeAppear : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject bridge ;
    public AudioSource sound;
    

   public void ActivateBridge()
   {
       sound = GetComponent<AudioSource>();
       sound.Play();
       
       if (bridge.active){
           bridge.SetActive(false);
           
       }
       else{
           
           bridge.SetActive(true);
           
       } 
   }
}
