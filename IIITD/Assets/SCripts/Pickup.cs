using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickup : MonoBehaviour {
    public GameObject shieldBox;
    public GameObject ammoBox;
    public bool haspickedupammo;
    public bool haspickedupshield;
    public GameObject player;
    //public currentPlayer cp;

	// Use this for initialization
	void Awake () {
        haspickedupammo = false;
        haspickedupshield = false;
        player = GetComponent<GameObject>();
        shieldBox = GetComponent<GameObject>();
        ammoBox = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        other = player.GetComponent<Collider>();

        if (other.CompareTag("Ammo"))
        {
            haspickedupammo = true;
            ammoBox.SetActive(false);
        }

        else if (other.CompareTag("Shield")){
            haspickedupshield = true;
            shieldBox.SetActive(false);
        }
            
    }
}
