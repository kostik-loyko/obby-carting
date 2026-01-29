using UnityEngine;

public class TriggerMoveTop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MoveTop>())
        {
            other.gameObject.GetComponent<MoveTop>().OnMoveTop();
        }
    }
}
