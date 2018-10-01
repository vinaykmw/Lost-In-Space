using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterScript : MonoBehaviour {  
    
    public float fireRate;
    public GameObject bullet;   
    public float bullet_force;
    float timeStamp = 0.0f;
    public float PerShotDelay = 1;
   // public ParticleSystem shotParticles;
    public GameObject player;
    public float nextFire = 0f;
    //public Rigidbody bulletRb;

    private bool fired;
    private bool isFiring = false;

    // Use this for initialization
    void Start () {
        bullet = GetComponent<GameObject>();
       
        //shotParticles = GetComponent<ParticleSystem>();
        
        player = GetComponent<GameObject>();
        
	}
    void Update()
    {
        //Aim();
        Shoot();
        if (fired)
        {
            Waitfornextfire(nextFire);
        }
        
       
    }

    /*void OnCollisionEnter(Collider other)
    {
        other = bullet.GetComponent<Collider>();
        if (other.CompareTag("everything") || other.CompareTag("Player"))
        {

        }
    }*/
    

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isFiring = true;
          
            timeStamp = Time.time + PerShotDelay;
            //StartCoroutine("fire");
           // GameObject Temporary_bullet_handler;
            /////GameObject Temporary_shoot_animation;
            //bullet = (GameObject) Instantiate(bullet, player.transform.position, player.transform.rotation) as GameObject;

            ///Temporary_shoot_animation = Instantiate (shoot_animation, Bullet_emmiter.transform.position, Quaternion.identity) as GameObject;
            ///Temporary_shoot_animation.transform.parent = Bullet_emmiter.transform;
            //Temporary_bullet_handler.tra
            //Rigidbody Temporary_rigidbody;
            //Temporary_rigidbody = Temporary_bullet_handler.GetComponents<Rigidbody> ();
            //bullet.GetComponent<Rigidbody>().AddForce(transform.forward * (-bullet_force));

            //Destroy (Temporary_shoot_animation, 5.0f);
            
        }
        isFiring = false;
        fired = true;
        nextFire += timeStamp;
    }

    /*void Aim()
    {
        
    }*/

    IEnumerator Waitfornextfire(float nextFire)
    {
        yield return new WaitForSeconds(nextFire);
      
    }
}
