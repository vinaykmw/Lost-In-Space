using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    public GameObject shield;
    private bool recharging;
    private bool shieldOn;
    public float shieldTimer = 50f;
    public GameObject player;
    public GUIText text;
    public Pickup pickup;
    IEnumerator REcharge_shield()
    {
        recharging = true;
        shieldOn = false;
        yield return new WaitForSeconds(5f);
        recharging = false;
        shieldOn = true;


    }

    // Use this for initialization
    void Awake () {
        shield = GetComponent<GameObject>();
        player = GetComponent<GameObject>();
        shieldOn = false;
        shield.SetActive(shieldOn);
        recharging = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (pickup.haspickedupammo == true)
        {
            ShieldOn();
        }
    }

    void ShieldOn()
    {
        if(recharging == false && shieldOn == false)
        {
            shield = Instantiate(shield, player.transform.position, player.transform.rotation);
            while(shieldTimer > 0f)
            {
                shieldTimer--;
            }

        }
        if(shieldTimer == 0f)
        {
            Destroy(shield);
            shieldOn = false;
        }

        recharging = true;
        StartCoroutine(REcharge_shield());

        if(recharging && Input.GetKeyDown(KeyCode.E))
        {
            text.text = "Wait for Shield to recharge!";
        }

    }
}
