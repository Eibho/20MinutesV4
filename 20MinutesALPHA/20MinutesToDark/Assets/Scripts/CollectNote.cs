using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectNote : MonoBehaviour
{

    public GameObject collectedNote;
    public GameObject cutSceneObject;
    


  

    // Start is called before the first frame update
    void Start()
    {
        cutSceneObject.SetActive(false);
        collectedNote.SetActive(false);

    }

    // Update is called once per frame
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            
            collectedNote.SetActive(true);
            cutSceneObject.SetActive(true);
            //destroy 
            Destroy(gameObject);

        }
    }
}
