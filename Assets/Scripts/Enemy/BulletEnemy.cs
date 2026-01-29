using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [SerializeField] GameObject hitParticle;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(hitParticle, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
                gameObject.transform.position.z), Quaternion.identity);

            Destroy(gameObject);
        }
    }
    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(4f);
        Instantiate(hitParticle, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
            gameObject.transform.position.z), Quaternion.identity);
        Destroy(gameObject);
    }
}
