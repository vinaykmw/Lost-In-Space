using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AI_FOLLOW_current : MonoBehaviour {
    
    NavMeshAgent agent;
    public GameObject[] respawns;
    public  bool notCurrent;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
       
	}
	
	// Update is called once per frame
	void Update () {
        notCurrent = this.gameObject.GetComponent<PlayerMovement>().isCurrentPlayer;
        if (notCurrent)
        {
            this.gameObject.GetComponent<NavMeshAgent>().enabled = true;
            respawns = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject respawn in respawns)
            {
                if (respawn.GetComponent<PlayerMovement>().isCurrentPlayer)
                {
                    agent.SetDestination ( respawn.transform.position);

                }
            }
        }
	}
}
