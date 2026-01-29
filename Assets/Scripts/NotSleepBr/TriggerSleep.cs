using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSleep : MonoBehaviour
{
    private bool agentSleep = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            agentSleep = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            agentSleep = true;

        }
    }
    public bool GetSleep()
    {
        return agentSleep;
    }
}
