using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeapleBehavior : MonoBehaviour
{
    [SerializeField] GameObject textNPC;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textNPC.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textNPC.SetActive(false);
        }
    }
}
