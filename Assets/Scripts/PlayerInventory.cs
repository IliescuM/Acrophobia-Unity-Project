using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class PlayerInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public int key = 0;

    public Text keycounter;

    public void PickupItem()
    {
        key++;


    }

    public void Update(){
        Scene scena = SceneManager.GetActiveScene();
        if(String.Equals(scena.name,"Game"))
        {
            keycounter.text = "Key: " + key + "/1";
        }
        if(String.Equals(scena.name,"GameStage2")) 
            keycounter.text = "Keys: " + key + "/3";

                    
                  
       
    }

}
