using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
  

    public void Quit()
    {
        Application.Quit();
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(0);
        // player.GetComponent<EnableDisable>().enabled = false;
        // player.GetComponent<Movement>().enabled = false;


        
        Debug.Log("restart");
    }


}
