using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject PlayerKey;
    public GameObject pickUpKey;
    public GameObject spotLight;

    MonsterRespawn deathScript;

    public AudioClip collectKey;

    AudioSource audioSource;

    private void Start()
    {
        PlayerKey.SetActive(false);
        pickUpKey.SetActive(true);
        spotLight.SetActive(false);

        audioSource = GetComponent<AudioSource>();

        deathScript = FindObjectOfType<MonsterRespawn>();
    }

    private void Update()
    {
        /*
        if(deathScript.died == true)
        {
            PlayerKey.SetActive(false);
            pickUpKey.SetActive(true);
            spotLight.SetActive(false);
        }
        else
        PlayerKey.SetActive(true);
        pickUpKey.SetActive(false);
        spotLight.SetActive(true);
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Key" && deathScript.died == false)
        {
            PlayerKey.SetActive(true);
            pickUpKey.SetActive(false);
            spotLight.SetActive(true);

            audioSource.PlayOneShot(collectKey);
        }
    }
}
