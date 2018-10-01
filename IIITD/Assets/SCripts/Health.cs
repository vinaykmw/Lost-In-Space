using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    public float health;
    public float currentHealth;
    public float bulletDamage = 20f;
    public float collisionDamage=10f;
    public bool alive;

    public Slider healthSlider;
    public GameObject player;
	// Use this for initialization
	void Awake () {
        player = GetComponent<GameObject>();
        health = 100f;
        alive = true;
        currentHealth = health;
	}

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        

       /*if (other.CompareTag())
        {
            health = health - bulletDamage;
        }*/
        if (other.CompareTag("Enemy"))
        {
            currentHealth = health- collisionDamage;
            healthSlider.value = currentHealth;

        }

        
    }
    private void Update()
    {
        if(health <= 0f)
        {
            alive = false;
            SceneManager.LoadScene(10);
            //Destroy(player);
            //StartCoroutine(killPlayer());
        }
    }

    IEnumerator killPlayer()
    {
        Time.timeScale = 0f;
        yield return new WaitForSeconds(.1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
