using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_Damage_to_player : MonoBehaviour {
    //Rigidbody rb;
	// Use this for initialization
	void Start () {
        DestroyObject(this.gameObject,0.8f);
   //     rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
       // rb.AddForce(Vector3.forward);
	}


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().health = other.GetComponent<Health>().health - 15;
            Debug.Log("hit");
      
            DestroyObject(this.gameObject);
        }

    }
}
