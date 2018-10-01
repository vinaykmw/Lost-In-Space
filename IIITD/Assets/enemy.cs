using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {

    public GameObject square;
    public GameObject sphere;
    public GameObject triangle;
    NavMeshAgent AGENT;
    public Transform finalTransform;
    int a;
    public int health;


    Health playerHealth;


    // Use this for initialization
    void Start () {

        AGENT = GetComponent<NavMeshAgent>();
        a = Random.Range(0, 5);
        playerHealth = GetComponent<Health>();

    }
	
	// Update is called once per frame
	void Update () {
        if (health > 0)
        {

            if (a >= 0 && a <= 1)
            {
                finalTransform = square.GetComponent<Transform>();
            }
            else if (a>1&&a<=3)
            {
             
                finalTransform = triangle.GetComponent<Transform>();
            }
            else if (a > 3)
            {
                finalTransform = sphere.GetComponent<Transform>();
            }
            
AGENT.SetDestination(finalTransform.position);
            // AGENT.SetDestination = finalTransform.position;
        }
        else
            Destroy(this.gameObject);



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet1"))
        {
            Debug.Log("hit");
            health=health - 50;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player"))
        {   other.GetComponent<Health>().health  = other.GetComponent<Health>().health - 15;
            Debug.Log("hit");
            health = health - 110;
           
        }

    }
}

/*
 * 
 * 
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {

    public GameObject square;
    public GameObject sphere;
    public GameObject triangle;
    NavMeshAgent AGENT;
    public Transform finalTransform;
    int a;
    public int health;

    Health playerHealth;


    // Use this for initialization
    void Start () {

        AGENT = GetComponent<NavMeshAgent>();
        a = Random.Range(0, 4);
        playerHealth = GetComponent<Health>();

    }
	
	// Update is called once per frame
	void Update () {
        if (health > 0)
        {

            if (a >= 0 && a <= 1)
            {
                finalTransform = square.GetComponent<Transform>();
            }
            else if (a == 2)
            {
                finalTransform = sphere.GetComponent<Transform>();
            }
            else
            {
                finalTransform = triangle.GetComponent<Transform>();
            }
            AGENT.SetDestination(finalTransform.position);
            // AGENT.SetDestination = finalTransform.position;
        }
        else
            Destroy(this.gameObject);



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet1"))
        {
            Debug.Log("hit");
            health=health - 50;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Player"))
        {   other.GetComponent<Health>().health  = other.GetComponent<Health>().health - 15;
            Debug.Log("hit");
            health = health - 110;
           
        }

    }
}

 * */
