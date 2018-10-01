using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour {
    public Animator animator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Opendoor()
    {
        animator.SetTrigger("Open");
    }
    public void Closedoor()
    {
        animator.SetTrigger("Close");
    }
}
