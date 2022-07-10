using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
        public AudioClip soundEffect;
        //public GameObject pickupEffect;
      private void OnTriggerEnter(Collider other) {

          PlayerInventory inventory = other.GetComponent<PlayerInventory>();
          if(inventory)
          {

              inventory.PickupItem();
              RemoveItem();
              
          }

         
         
          }

      private void RemoveItem(){
          AudioSource.PlayClipAtPoint(soundEffect,transform.position);
          //Instantiate(pickupEffect,transform.position,Quaternion.identity);
          Destroy(gameObject);
      }
        
 }
