using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    // Start is called before the first frame update
   public UnityEvent myTrigger;
    public GameObject secretStone;


   private   void OnTriggerEnter(Collider other) {
       if(other.CompareTag("Player"))
       {
             myTrigger.Invoke();
       }
   }
}
