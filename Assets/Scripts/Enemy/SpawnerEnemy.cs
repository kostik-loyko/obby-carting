using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using static UnityEngine.Rendering.DebugUI;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject[] enemys;
    [SerializeField] int index;
    private void Start()
    {
        SpawnEnemyStart();
    }

    private void OnEnable() => EventManager.deathEnemy += SpawnEnemy;

    private void OnDisable() => EventManager.deathEnemy -= SpawnEnemy;

    private void SpawnEnemy(int value)
    {
        StartCoroutine(CorutinSpawnEnemy(value));
    }
    private void SpawnEnemyStart()
    {
        int randomEnemy = Random.Range(0, enemys.Length);
        Instantiate(enemys[randomEnemy], spawnPoint.position, Quaternion.identity);
    }
    private IEnumerator CorutinSpawnEnemy(int value)
    {
        if(value == index)
        {
            float spawnDelay = Random.Range(75, 95);
            yield return new WaitForSeconds(spawnDelay);
            int randomEnemy = Random.Range(0, enemys.Length);
            Instantiate(enemys[randomEnemy], spawnPoint.position, Quaternion.identity);
        }
    }
}
