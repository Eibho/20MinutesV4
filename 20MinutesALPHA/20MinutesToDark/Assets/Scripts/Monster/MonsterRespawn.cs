using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRespawn : MonoBehaviour
{
    public bool died = false;
   
    public Transform monsterSpawn;
    public Transform playerSpawn;
    
    public GameObject monster;
    public GameObject player;

    public GameObject cooldownUI;
    public GameObject deathUI;
    

    private void Start()
    {
        cooldownUI.SetActive(true);
        deathUI.SetActive(false);
        died = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("MonsterRespawn");

            cooldownUI.SetActive(false);
            deathUI.SetActive(true);

            died = true;

            //StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);

        died = true;

        monster.transform.position = monsterSpawn.transform.position;
        player.transform.position = playerSpawn.transform.position;
    }

}