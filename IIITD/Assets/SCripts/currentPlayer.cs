using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentPlayer : MonoBehaviour {
    public GameObject Square;
    public GameObject Sphere;
    public GameObject Triangle;
    public GameObject camera;
    public int current = 0;
	// Use this for initialization
	void Start () {
        current = 0;
        toggel();
	}
    public void toggel()
    {
        Square.GetComponent<PlayerMovement>().isCurrentPlayer = false;
        Sphere.GetComponent<PlayerMovement>().isCurrentPlayer = false;
        Triangle.GetComponent<PlayerMovement>().isCurrentPlayer = false;

        if (current == 0)
        {
            Square.GetComponent<PlayerMovement>().isCurrentPlayer = true;
            Square.GetComponent<PlayerMovement>().enabled = true;
            //Square.GetComponent<Rigidbody>().isKinematic = true;
            Square.GetComponent<Light>().color = Color.green;
            Square.GetComponent<PlayerMovement>().isCurrentPlayer = true;

            Sphere.GetComponent<PlayerMovement>().enabled = false;
            //Sphere.GetComponent<Rigidbody>().isKinematic = false;
            Sphere.GetComponent<Light>().color = Color.grey;

            Triangle.GetComponent<PlayerMovement>().enabled = false;
            //Triangle.GetComponent<Rigidbody>().isKinematic = false;
            Triangle.GetComponent<Light>().color = Color.grey;
        }
        if (current == 1)
        {
            Sphere.GetComponent<PlayerMovement>().isCurrentPlayer = true;

            Square.GetComponent<PlayerMovement>().enabled = false;
           // Square.GetComponent<Rigidbody>().isKinematic = false;
            Square.GetComponent<Light>().color = Color.grey;

            Sphere.GetComponent<PlayerMovement>().enabled = true;
            //Sphere.GetComponent<Rigidbody>().isKinematic = true;
            Sphere.GetComponent<Light>().color = Color.red;

            Triangle.GetComponent<PlayerMovement>().enabled = false;
           // Triangle.GetComponent<Rigidbody>().isKinematic = false;
            Triangle.GetComponent<Light>().color = Color.grey;
        }
        if (current == 2)
        {
            Triangle.GetComponent<PlayerMovement>().isCurrentPlayer = true;

            Square.GetComponent<PlayerMovement>().enabled = false;
           // Square.GetComponent<Rigidbody>().isKinematic = false;
            Square.GetComponent<Light>().color = Color.grey;

            Sphere.GetComponent<PlayerMovement>().enabled = false;
           // Sphere.GetComponent<Rigidbody>().isKinematic = false;
            Sphere.GetComponent<Light>().color = Color.grey;

            Triangle.GetComponent<PlayerMovement>().enabled = true;
            //Triangle.GetComponent<Rigidbody>().isKinematic = true;
            Triangle.GetComponent<Light>().color = Color.blue;
        }
        camera.GetComponent<cameraMover>().SetTarget(current);
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            current++;
            if (current > 2)
            {
                current = 0;
            }
            toggel();
        }
	}




}
