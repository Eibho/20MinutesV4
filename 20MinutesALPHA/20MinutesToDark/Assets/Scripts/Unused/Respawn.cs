using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    //respawn
    public Transform respawnPoint;
    public GameObject player;

    public GameObject cooldownUI;
    public GameObject deathUI;


    private void Start()
    {
        cooldownUI.SetActive(true);
        deathUI.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Respawn");
            cooldownUI.SetActive(false);
            deathUI.SetActive(true);
            //StartCoroutine(Wait());


        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        player.transform.position = respawnPoint.transform.position;
    }
    
}

