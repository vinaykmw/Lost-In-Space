using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMover : MonoBehaviour {
    public Vector3 offset;
    public Transform Square;
    public Transform sphere;
    public Transform triangle;
    int targetPlayer;
    public float smothness;
    // Use this for initialization
    void Start () {
         offset = -Square.GetComponent<Transform>().position + this.transform.position;
       
	}
	
	// Update is called once per frame
	void Update () {
        if (targetPlayer == 0)
        {
            transform.position = Vector3.Lerp(transform.position, Square.position + offset, smothness * Time.deltaTime);
        }
        else if (targetPlayer ==1){
            transform.position = Vector3.Lerp(transform.position, sphere.position + offset, smothness * Time.deltaTime);
        }
        else
            transform.position = Vector3.Lerp(transform.position, triangle.position + offset, smothness * Time.deltaTime);


    }

    public void SetTarget(int a)
    {
        targetPlayer = a;


    }
}
