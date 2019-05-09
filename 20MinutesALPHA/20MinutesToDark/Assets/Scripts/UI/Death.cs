using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    MonsterRespawn respawn;

     EnableDisable enableDisable;
     Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        respawn = GetComponent<MonsterRespawn>();

        enableDisable = GetComponent<EnableDisable>();
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (respawn.died == true)
        {
            Debug.Log("ded");
            enableDisable.GetComponent<EnableDisable>().enabled = false;
            movement.GetComponent<EnableDisable>().enabled = false;
        }
        else
        enableDisable.GetComponent<EnableDisable>().enabled = true;
        movement.GetComponent<EnableDisable>().enabled = true;
        */
    }
}
