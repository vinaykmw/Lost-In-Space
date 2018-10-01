using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increment_pickup : MonoBehaviour {
   public GameObject incrementer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag( "Player"))
        {
            incrementer.GetComponent<pickup_script>().addPickup();
        
            Object.Destroy(this.gameObject);
        }
    }
}
