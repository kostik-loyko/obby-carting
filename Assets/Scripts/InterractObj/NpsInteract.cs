using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpsInteract : MonoBehaviour
{
    [SerializeField] int index;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (DialogSystem.Instance.enableNextDialog)
            {
                DialogSystem.Instance.StartDialog();
                //if (GameManager.Instance.isRU)
                //{
                //    SoundManager.Instance.PlayHello();
                //}
            }
            SoundManager.Instance.SpeakOldNPC(index);
        }
    }
}
