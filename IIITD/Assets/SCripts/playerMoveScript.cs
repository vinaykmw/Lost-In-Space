using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveScript : MonoBehaviour {
    public GameObject Sphere;
    public GameObject Square;
    public GameObject Triangle;
    public Vector3 movement;
    public float speed;
    Rigidbody rb;
    public float camRayLength = 100f;
    public int playerCount=0;
    int floorMask;
    // Use this for initialization
    void Start () {
        floorMask = LayerMask.GetMask("Floor");
        TogglePlayer();
    }
    void TogglePlayer()
    {
        
        if(playerCount==1)
         rb = Square.GetComponent<Rigidbody>();
        else if (playerCount == 2)
            rb = Sphere.GetComponent<Rigidbody>();
        else if (playerCount == 3)
            rb = Triangle.GetComponent<Rigidbody>();

        playerCount++;
        if (playerCount > 3)
        {
            playerCount = 1;
        }

    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
           {
            TogglePlayer();
            }

     /*   float x;
        float z;
        x = Input.GetAxis("Vertical");
        z = Input.GetAxis("Horizontal");

            rb.velocity = new Vector3(x, 0, z) * ForceMAgnitude;  */

	}


    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // Move the player around the scene.
        Move(h, v);

        // Turn the player to face the mouse cursor.
        Turning();
    }

    void Move(float h, float v)
    {
        // Set the movement vector based on the axis input.
        movement.Set(h, 0f, v);

        // Normalise the movement vector and make it proportional to the speed per second.
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the player to it's current position plus the movement.
        rb.MovePosition(transform.position + movement);
    }

    void Turning()
    {
        // Create a ray from the mouse cursor on screen in the direction of the camera.
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Create a RaycastHit variable to store information about what was hit by the ray.
        RaycastHit floorHit;

        // Perform the raycast and if it hits something on the floor layer...
        if (Physics.Raycast(camRay, out floorHit, camRayLength, floorMask))
        {
            // Create a vector from the player to the point on the floor the raycast from the mouse hit.
            Vector3 playerToMouse = floorHit.point - transform.position;

            // Ensure the vector is entirely along the floor plane.
            playerToMouse.y = 0f;

            // Create a quaternion (rotation) based on looking down the vector from the player to the mouse.
            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

            // Set the player's rotation to this new rotation.
            rb.MoveRotation(newRotation);
        }
    }
}
