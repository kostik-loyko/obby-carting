using UnityEngine;
using System.Collections;
using YG;

public class NeckNPC : MonoBehaviour
{
    [SerializeField] int index;
    [SerializeField] Transform[] waypoints; // Массив точек, по которым будет двигаться NPC
    private float speed = 3f; // Скорость движения
    private float rotationSpeed = 2f; // Скорость поворота

    private int currentWaypointIndex = 0;
    private Transform currentTarget;

    [SerializeField] Transform neck;
    [SerializeField] GrowNeck growNeck;

    void Start()
    {
        if (waypoints.Length > 0)
        {
            currentTarget = waypoints[currentWaypointIndex];
        }
        StartCoroutine(UpNeckSecond());
    }
    void Update()
    {
        MoveToWaypoint();
        RotateToMovementDirection();
    }
    void MoveToWaypoint()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
            currentTarget = waypoints[currentWaypointIndex];
        }
    }
    void RotateToMovementDirection()
    {
        Vector3 moveDirection = (currentTarget.position - transform.position).normalized;
        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private IEnumerator UpNeckSecond()
    {
        yield return new WaitForSeconds(1f);
        if (index == 0)
        {
            neck.localPosition = new Vector3(0, growNeck.GetNeckLocalPosition() - 4, 0);
        }
        if (index == 1)
        {
            neck.localPosition = new Vector3(0, growNeck.GetNeckLocalPosition() + 6, 0);
        }
        if (index == 2)
        {
            neck.localPosition = new Vector3(0, growNeck.GetNeckLocalPosition() + 1, 0);
        }
        if (index == 3)
        {
            neck.localPosition = new Vector3(0, growNeck.GetNeckLocalPosition(), 0);
        }
        StartCoroutine(UpNeckSecond());
    }
}
