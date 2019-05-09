using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    Animator anim;

    AudioSource audioSource;
    public AudioClip openGate;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("OpenGate", false);

        audioSource = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PlayerKey")
        {
            anim.SetBool("OpenGate",true);
            audioSource.PlayOneShot(openGate);
            
        }
    }

    

}
