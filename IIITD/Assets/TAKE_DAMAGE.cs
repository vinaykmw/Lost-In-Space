using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TAKE_DAMAGE : MonoBehaviour {

  public  int WALL_HEALTH;
    public GameObject healthref;
    public Image bar;

	// Use this for initialization
	void Start () {
        WALL_HEALTH = 700;
        bar = healthref.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        bar.fillAmount = WALL_HEALTH / 700f;
        if (WALL_HEALTH <= 0)
        {
            DestroyObject(this.gameObject);
            
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet1"))
        {
            Debug.Log("hit");
            WALL_HEALTH = WALL_HEALTH - 50;
            other.gameObject.SetActive(false);
        }
        

    }
}
