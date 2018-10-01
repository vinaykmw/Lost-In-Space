using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatCode : MonoBehaviour {
    public string[]  cheatode;
    public int index;

	// Use this for initialization
	void Start () {
		cheatode = new string[] { "s", "p", "a", "c", "e" };
        index = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(cheatode[index]))
            {
                index++;
            }
            else
            {
                index = 0;
            }

            if(index ==cheatode.Length)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
	}
}
