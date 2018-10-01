using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTrigger : MonoBehaviour {
    public Rwall movement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CTrigger"))
        {
            movement.open = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        movement.open = false;
    }
}
