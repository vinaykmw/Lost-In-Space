using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemy : MonoBehaviour
{
    public GameObject[] spawnObject = new GameObject[5];
    public GameObject terrorist;
    int noOfterrorist;
    public float start_wait;
    bool canchange;

    void Start()
    {
        StartCoroutine(SpawnTerrorist());
        noOfterrorist = 10;
        canchange = true;
    }

    IEnumerator SpawnTerrorist()
    {
        yield return new WaitForSeconds(start_wait);

        while (true)
        {//int 
            int gos = GameObject.FindGameObjectsWithTag("Enemy").Length;

            for (int i = 0; i < noOfterrorist; i++)
            {
                int k = Random.Range(0, 5);
                if (gos < 5)
                {
                    Instantiate(terrorist, spawnObject[k].transform);
                    StartCoroutine(changeno()); StartCoroutine(changeno());
                }

                yield return new WaitForSeconds(1f);
            }


        }
    }

    IEnumerator changeno()
    {

        if (canchange && noOfterrorist < 10)
        {
            noOfterrorist = noOfterrorist + 1;
            canchange = false;
        }
        yield return new WaitForSeconds(60f);
        canchange = true;

    }


}
