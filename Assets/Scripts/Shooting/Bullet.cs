using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject hitBlood;
    [SerializeField] GameObject hitExpload;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(hitBlood, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
                gameObject.transform.position.z), Quaternion.identity);

            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Aim"))
        {
            Instantiate(hitExpload, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
                gameObject.transform.position.z), Quaternion.identity);

            Destroy(gameObject);
        }
    }
    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
}
