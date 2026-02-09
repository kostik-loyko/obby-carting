using UnityEngine;

public class TriggerMoveBottom : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<MoveTop>())
        {
            other.gameObject.GetComponent<MoveTop>().OnMoveBottomWithTop();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<MoveTop>())
        {
            other.gameObject.GetComponent<MoveTop>().OffMoveBottomWithTop();
        }
    }
}
