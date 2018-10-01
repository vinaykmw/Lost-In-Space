using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rwall : MonoBehaviour {
    Vector3 fp, lp;
    public bool open = false;
    private void Start()
    {
        fp = transform.position;
        lp = fp;
        lp.y = lp.y + 20;
        
    }
    void Update()
        {
        if(open)
        transform.position = Vector3.Lerp(this.transform.position, lp, 0.01f); 
        else
        {
            transform.position = Vector3.Lerp(this.transform.position, fp, 0.1f);
        }
    }
    
}
