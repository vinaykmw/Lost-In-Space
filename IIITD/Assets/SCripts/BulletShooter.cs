using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour {
    public GameObject bullet_Emmiter;
    public GameObject Bullet_prefab;
    public float forwardPushForce;
    public GameObject playerRef;
    public bool gunActive = true;
    public GameObject player;
    public Pickup pickup;
    public float bulletRange=.65f;
  
 
	// Use this for initialization
	void Awake () {
        gunActive = playerRef.GetComponent<PlayerMovement>().isCurrentPlayer;
        player = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

     /*   if (pickup.haspickedupammo)
        {*/
            gunActive = playerRef.GetComponent<PlayerMovement>().isCurrentPlayer;
            if (Input.GetMouseButtonDown(0) && gunActive)
            {
                GameObject tempBullet;
                tempBullet = Instantiate(Bullet_prefab, bullet_Emmiter.transform.position, bullet_Emmiter.transform.rotation) as GameObject;

                tempBullet.transform.Rotate(Vector3.left * 90);

                Rigidbody temp_rigidbody;
                temp_rigidbody = tempBullet.GetComponent<Rigidbody>();
                temp_rigidbody.AddForce(transform.forward * forwardPushForce);
                Destroy(tempBullet, bulletRange);

            }
      //  }
       
	}

   

    
}
