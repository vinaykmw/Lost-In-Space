using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pickup_script : MonoBehaviour {
    public float totalPickups=10;
    public float pickups;
    public Text WinText;

    public Text charge;
	// Use this for initialization
	void Start () {
        pickups = 0;
	}
	
	// Update is called once per frame
	void Update () {
        charge.text = ((pickups / totalPickups)*100f).ToString() + "%";
        if (pickups == totalPickups)
        {
            WinText.text = " You Win";
            if(SceneManager.GetActiveScene().buildIndex==8)
                SceneManager.LoadScene(9);
        }
        
	}

    public void addPickup()
    {
        pickups++;
    }
}
