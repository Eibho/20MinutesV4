using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        source = FindObjectOfType<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
