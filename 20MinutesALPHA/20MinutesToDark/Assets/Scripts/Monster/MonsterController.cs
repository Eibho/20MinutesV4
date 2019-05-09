using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public float followRadius = 10f;
    Transform player;
    NavMeshAgent agent;

    public float sprintSpeed = 5f;
    public float speed = 3.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        // player = PlayerManager.instance.player.transform;
        Transform player;

    }

    private void Update()
    {
        // float distance = Vector3.Distance(player.position, transform.position);

        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent.SetDestination(player.position);

        Sprint();
        
    }

    // Update is called once per frame
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, followRadius);

        
    }

    void Sprint()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<NavMeshAgent>().speed = sprintSpeed;
        }
        else if (Input.GetKey(KeyCode.RightShift))
        {
            GetComponent<NavMeshAgent>().speed = sprintSpeed;
        }

        else
            GetComponent<NavMeshAgent>().speed = speed;
    }
}
