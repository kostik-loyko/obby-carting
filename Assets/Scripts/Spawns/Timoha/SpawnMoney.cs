using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoney : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject moneyPrefs;
    float spawnRadius = 0.3f;

    void Start()
    {
        StartCoroutine(WaitSpawnMoney());
    }
    private IEnumerator WaitSpawnMoney()
    {
        Vector3 position = new Vector3(Random.Range(0, 180), Random.Range(0, 180), Random.Range(0, 180));

        Instantiate(moneyPrefs, spawnPoint.position + Random.insideUnitSphere * spawnRadius,
            Quaternion.Euler(position));

        yield return new WaitForSeconds(3f);

        StartCoroutine(WaitSpawnMoney());
    }
}
