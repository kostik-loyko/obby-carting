using UnityEngine;

public class CupSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cupPrefab;

    private void OnEnable()
    {
        EventManager.cupSpawn += SpawnCup;
    }
    private void OnDisable()
    {
        EventManager.cupSpawn -= SpawnCup;
    }
    private void SpawnCup()
    {
        Instantiate(_cupPrefab, transform.position, Quaternion.identity);
    }
}
