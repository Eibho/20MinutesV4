using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    GameObject monster;
    float theDistance = 50;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        monster = GameObject.FindGameObjectWithTag("Enemy");
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Flicker();
       // anim.SetBool("isFlicker", false);
    }

    void Flicker()
    {
        
        float distance = Vector3.Distance(transform.position, monster.transform.position);

        if (distance <= theDistance)
        {
            Debug.Log("Flicker");
            anim.SetBool("isFlicker", true);
        }
        else
            anim.SetBool("isFlicker", false);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("monster");
            anim.SetBool("isFlicker", true);
        }
        else
        anim.SetBool("isFlicker", false);
    }
}
