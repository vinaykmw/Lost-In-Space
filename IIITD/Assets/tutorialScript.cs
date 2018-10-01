using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialScript : MonoBehaviour {
    public int displayIth;
    public Text a;
    public string[] strings;
    // Use this for initialization

    IEnumerator textNull()
    {
        yield return new WaitForSeconds(2);
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            a.text = strings[displayIth];
            StartCoroutine(textNull());
        }
    }
}
