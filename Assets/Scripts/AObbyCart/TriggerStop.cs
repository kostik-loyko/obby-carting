using UnityEngine;

public class TriggerStop : MonoBehaviour
{
    [SerializeField] int _index;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<MoveTop>())
        {
            other.gameObject.GetComponent<MoveTop>().StopMove(_index);
        }
    }
}