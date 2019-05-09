using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vignette : MonoBehaviour
{
    public GameObject image;
    GameObject player;

    bool isTrigger = false;

   // public float theDistance = 50;

    // Start is called before the first frame update
    void Start()
    {
       
        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(isTrigger == true)
        {
            image.SetActive(true);
        }
        else if (isTrigger == false)
        {
            image.SetActive(false);
        }
        
        /*
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= theDistance)
        {
            image.SetActive(true);
        }
        else
            image.SetActive(false);
            */
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if(isTrigger == false)
            {
                isTrigger = true;
                //image.SetActive(true);
            }
        }
      
    
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            if(isTrigger == true)
            {
                isTrigger = false;
            }
        }
    }
}
