using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIClickHelp : MonoBehaviour
{
    public GameObject image;
    GameObject player;

    bool isTrigger = false;

    
    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        if (isTrigger == true)
        {
            image.SetActive(true);
        }
        else if (isTrigger == false)
        {
            image.SetActive(false);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isTrigger == false)
            {
                isTrigger = true;
            }
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isTrigger == true)
            {
                isTrigger = false;
            }
        }
    }
}
