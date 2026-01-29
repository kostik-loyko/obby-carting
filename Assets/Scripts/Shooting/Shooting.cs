using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shooting : MonoBehaviour
{
    public static Shooting Instance { get; set; }

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
    [SerializeField] Transform hitPartPoint;
    [SerializeField] GameObject bulletPrefab;

    float bulletForce = 40f;

    private bool isMobile;
    private bool isReadyShoot = true;

    [SerializeField] private Animator _animatorWeap;
    [SerializeField] GameObject hitPart;

    private void Start()
    {
        isMobile = MobileInputManager.Instance.IsMobileDevice();
    }

    public void ShootingGun()
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
    public void Shoot()
    {
        if (isReadyShoot)
        {
            isReadyShoot = false;

            _animatorWeap.SetBool("Shoot", true);

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            hitPart.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            Instantiate(hitPart, hitPartPoint.position, firePoint.rotation);
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);

            StartCoroutine(WaitShoot());
            SoundManager.Instance.bullet.Play();
        }
    }

    private IEnumerator WaitShoot()
    {
        yield return new WaitForSeconds(0.2f);
        _animatorWeap.SetBool("Shoot", false);
        isReadyShoot = true;
    }
}