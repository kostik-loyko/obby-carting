using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerStop : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<MoveTop>())
        {
            other.gameObject.GetComponent<MoveTop>().StopMove();
        }
    }
}
