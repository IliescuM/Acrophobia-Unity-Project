using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class WinCondition : MonoBehaviour
{    
    public static bool GameIsWin = false;
    public GameObject WinMenuUi;

    

  private void OnTriggerEnter(Collider other) {
          Scene scena = SceneManager.GetActiveScene();
          PlayerInventory inventory = other.GetComponent<PlayerInventory>();
            if (inventory){
                Debug.Log("am ajuns aici in inventar");
                Debug.Log(inventory.key);
                if(inventory.key == 1 && String.Equals(scena.name,"Game")){
                    
                    SceneManager.LoadScene("GameStage2");
                }

                if(inventory.key == 3  && String.Equals(scena.name,"GameStage2")) {
                    Debug.Log("am ajuns aici");
                    Pause();
                     }
           
    

  }
  }
   public void Pause() 
        {
            WinMenuUi.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;


            GameIsWin = true;
        }
    public void LoadMenu(){
        Debug.Log("Loading Menu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");

    }
    public void QuitGame(){
        Debug.Log("Quitting Menu");
        Application.Quit();

    }
}
