using UnityEngine;

public class SpawnerBr : MonoBehaviour
{
    [SerializeField] GameObject prefabBr;
    float minRadius = 5f;
    float maxRadius = 100f;
    float probability = 0.5f;

    public void SpawnBr()
    {
        if (Random.value <= probability)
        {
            float randomRadius = Random.Range(minRadius, maxRadius);
            float randomAngle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
            float xPos = transform.position.x + randomRadius * Mathf.Cos(randomAngle);
            float zPos = transform.position.z + randomRadius * Mathf.Sin(randomAngle);
            Vector3 spawnPosition = new Vector3(xPos, transform.position.y, zPos);
            Instantiate(prefabBr, spawnPosition, Quaternion.identity);
        }
    }
}
