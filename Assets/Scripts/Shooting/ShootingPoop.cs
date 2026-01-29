using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPoop : MonoBehaviour
{
    public static ShootingPoop Instance { get; set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] MeshRenderer poopWeapon;

    float bulletForce = 18f;

    private bool isMobile;
    private bool isReadyShoot = true;

    private void Start()
    {
        isMobile = MobileInputManager.Instance.IsMobileDevice();
    }

    public void ShootPoop()
    {
        if (isMobile && SimpleInput.GetButtonDown("Punch") &&
    GameManager.Instance.punchEnanle)
        {
            Shoot();
        }
        else if (!isMobile && Input.GetMouseButtonDown(0) &&
            GameManager.Instance.punchEnanle)
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        if (isReadyShoot)
        {
            isReadyShoot = false;

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);

            StartCoroutine(WaitShoot());
            SoundManager.Instance.swish.Play();
        }
    }

    private IEnumerator WaitShoot()
    {
        poopWeapon.enabled = false;
        yield return new WaitForSeconds(1f);
        isReadyShoot = true;
        poopWeapon.enabled = true;
    }
}
