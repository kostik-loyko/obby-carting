using UnityEngine;

public class TriggerCup : MonoBehaviour
{
    [SerializeField] private float _cup;
    [SerializeField] private GameObject _partCup;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>())
        {
            Score.Instance.UpCup(_cup);
            Instantiate(_partCup, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
