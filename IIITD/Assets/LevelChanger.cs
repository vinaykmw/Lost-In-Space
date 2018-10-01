using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChanger : MonoBehaviour {

    public Animator animator;
    private int levelLoad;
	// Update is called once per frame
	void Update () {
       // if (SceneManager.GetActiveScene().buildIndex + 1 == 3)
         //   if (Input.GetButtonDown("Submit"))
           //     FadeToLevel(1);
        //else
            if(Input.GetMouseButtonDown(0))
        {
            FadeToNextLevel();
        }
		
	}
    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void FadeToLevel(int levelIndex)
    {
        levelLoad = levelIndex;
        animator.SetTrigger("Fade_Out");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelLoad);
    }
}
