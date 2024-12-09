using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.AI;

public class Goomba : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.otherCollider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
