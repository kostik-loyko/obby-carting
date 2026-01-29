using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] bool isMetalDoor;
    [SerializeField] GameObject turn;
    private bool isEnterTrigger = true;
    private bool isExiteTrigger = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isExiteTrigger = true;
            if (isEnterTrigger)
            {
                isEnterTrigger = false;

                turn.transform.Rotate(0, -90, 0);
                if(isMetalDoor)
                {
                    SoundManager.Instance.openMetalDoor.Play();
                } else
                {
                    SoundManager.Instance.openDoor.Play();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isEnterTrigger = true;
            if (isExiteTrigger)
            {
                isExiteTrigger = false;

                turn.transform.Rotate(0, 90, 0);
                if (isMetalDoor)
                {
                    SoundManager.Instance.closeMetalDoor.Play();
                }
                else
                {
                    SoundManager.Instance.closeDoor.Play();
                }
            }
        }
    }
}
