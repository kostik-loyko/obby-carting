using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class DoorMove : MonoBehaviour
{
    [SerializeField] GameObject part1;
    [SerializeField] GameObject part2;

    private Vector3 startPosition1;
    private Vector3 startPosition2;
    [SerializeField] float distanceToMove;
    [SerializeField] int speed;

    private bool isEnterTrigger = false;
    private bool isExiteTrigger = false;

    private bool isSoundPlay = true;
    private bool isSoundStop = true;

    private void Start()
    {
        startPosition1 = part1.transform.position;
        startPosition2 = part2.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isEnterTrigger = true;
            isExiteTrigger = false;

            isSoundStop = true;
            if (isSoundPlay)
            {
                isSoundPlay = false;
                SoundManager.Instance.doorMove.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isExiteTrigger = true;
            isEnterTrigger = false;

            isSoundPlay = true;
            if (isSoundStop)
            {
                isSoundStop = false;
                SoundManager.Instance.doorMove.Play();
            }
        }
    }

    public void OpenDoor()
    {
        if (Vector3.Distance(part1.transform.position, startPosition1) < distanceToMove)
        {
            part1.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Vector3.Distance(part2.transform.position, startPosition2) < distanceToMove)
        {
            part2.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    public void CloseDoor()
    {
        if (Vector3.Distance(part1.transform.position, startPosition1) > 0)
        {
            part1.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Vector3.Distance(part2.transform.position, startPosition2) > 0)
        {
            part2.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
    public void ChangeDoor()
    {
        if (isEnterTrigger)
        {
            OpenDoor();
        }
        if (isExiteTrigger)
        {
            CloseDoor();
        }
    }
}
