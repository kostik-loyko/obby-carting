using UnityEngine;
using System.Collections;

public class SpawnerFruit : MonoBehaviour
{
    [SerializeField] GameObject[] prefabsToSpawn; // Префаб объекта для спавна
    float minRadius = 5f;     // Минимальный радиус для спавна
    float maxRadius = 100f;    // Максимальный радиус
    int numberOfObjects = 25;  // Сколько объектов спавнить
    float probability = 0.5f;

    [SerializeField] Transform centerObject;
    void Start()
    {
        SpawnTreesStart();
    }

    IEnumerator SpawnTreesStartCorut()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 randomPoint = Random.insideUnitSphere;
            float randomRadius = Random.Range(50, 150);
            Vector3 spawnPosition = centerObject.position + randomPoint * randomRadius;
            int randomInt = Random.Range(0, prefabsToSpawn.Length);
            Instantiate(prefabsToSpawn[randomInt], spawnPosition, Quaternion.identity);
        }
    }
    public void SpawnTreesStart()
    {
        StartCoroutine(SpawnTreesStartCorut());
    }
    public void SpawnTree()
    {
        if (Random.value <= probability)
        {
            float randomRadius = Random.Range(minRadius, maxRadius);
            float randomAngle = Random.Range(0f, 360f) * Mathf.Deg2Rad;
            float xPos = transform.position.x + randomRadius * Mathf.Cos(randomAngle);
            float zPos = transform.position.z + randomRadius * Mathf.Sin(randomAngle);
            Vector3 spawnPosition = new Vector3(xPos, transform.position.y, zPos);
            int randomInt = Random.Range(0, prefabsToSpawn.Length);
            Instantiate(prefabsToSpawn[randomInt], spawnPosition, Quaternion.identity);
        }
    }
    public void SetHeightTreeSpawner(int heightPos)
    {
        transform.position = new Vector3(transform.position.x, heightPos + 50, transform.position.z);
    }
}
