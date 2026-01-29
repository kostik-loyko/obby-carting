using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestActivate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EventAction.Instance.ShowQuest();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EventAction.Instance.HideQuest();
        }
    }
}
