using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningScene : MonoBehaviour
{
    public float cutSceneTime = 10f;

    public GameObject playerObject;
    public GameObject cutscene;
    public GameObject monster;

    bool isTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        playerObject.SetActive(true);
        cutscene.SetActive(false);
        monster.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     if(isTriggered == true)
        {
            StartCoroutine(Timer());
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isTriggered = true;
            
        }
        
    }

    IEnumerator Timer()
    {
        
        playerObject.SetActive(false);
        cutscene.SetActive(true);
        yield return new WaitForSeconds(cutSceneTime);
        Debug.Log("back to black");
        playerObject.SetActive(true);
        monster.SetActive(true);
        cutscene.SetActive(false);
        Destroy(gameObject);
    }
}
