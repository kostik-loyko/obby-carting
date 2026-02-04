using UnityEngine;

public class PetController : MonoBehaviour
{

    Transform player;
    [SerializeField] float followDistance = 3f;
    float moveSpeed = 5f;

    void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);
        if (distance > followDistance)
        {
            Vector3 desiredOffset = player.forward * -followDistance;
            Vector3 desiredPosition = player.position + desiredOffset;

            desiredPosition.y = player.position.y;

            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, moveSpeed * Time.deltaTime);

        }

        transform.position = new Vector3(transform.position.x, player.position.y - 1, transform.position.z);

        transform.LookAt(player.position);
    }
}

