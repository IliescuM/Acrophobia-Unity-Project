using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretStone : MonoBehaviour
{
    public float pushPower = 2.0F;

   
    public GameObject secretStone;
    // Start is called before the first frame update
      

      void OnCollisionEnter(Collision other) {
          
          if(other.gameObject.tag == "Player")
          {
            secretStone.SetActive(true);
            
          }

      }       

    
    
}
