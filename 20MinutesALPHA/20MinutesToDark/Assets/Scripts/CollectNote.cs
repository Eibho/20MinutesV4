using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectNote : MonoBehaviour
{

    public GameObject collectedNote;

    //audio
    public AudioSource audioSource;
    public AudioClip note;
  

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        //deactivate the collected note
        collectedNote.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //play note
            audioSource.PlayOneShot(note);
            //activate collected note
            collectedNote.SetActive(true);
            //destroy 
            Destroy(gameObject);

        }
    }
}
