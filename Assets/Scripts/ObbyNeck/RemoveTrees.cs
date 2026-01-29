using System;
using UnityEngine;

public class RemoveTrees : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            Destroy(other.gameObject);
        }
    }
}
