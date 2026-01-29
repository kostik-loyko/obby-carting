using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoop : MonoBehaviour
{
    [SerializeField] SphereCollider sphereCollider0;
    [SerializeField] SphereCollider sphereCollider1;
    [SerializeField] GameObject hitExpload;
    void Start()
    {
        StartCoroutine(WaitCollaider());
        StartCoroutine(DestroyBulletCor());
    }

    private IEnumerator WaitCollaider()
    {
        yield return new WaitForSeconds(0.2f);
        sphereCollider0.enabled = true;
        sphereCollider0.enabled = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            DestroyBullet();
        }
    }
    private void DestroyBullet()
    {
        Instantiate(hitExpload, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
            gameObject.transform.position.z), Quaternion.identity);

        Destroy(gameObject);
    }

    private IEnumerator DestroyBulletCor()
    {
        yield return new WaitForSeconds(5f);

        DestroyBullet();
    }
}
