using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerscript : MonoBehaviour {

    public anim oper;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("trigger");
            oper.Opendoor();
        }
    }
    private void OnTriggerExit(Collider other)
    {
      //  oper.Closedoor();
    }
}
