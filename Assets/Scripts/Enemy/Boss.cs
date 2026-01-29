using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePoint1;
    [SerializeField] Transform firePoint2;
    [SerializeField] Transform firePoint3;
    [SerializeField] Transform firePoint4;
    [SerializeField] GameObject bulletPrefab;

    [SerializeField] GameObject deathPart;
    [SerializeField] GameObject moneyText;
    int HP = 25;
    [SerializeField] int index;
    float money = 10000f;
    float bulletForce = 12f;

    private void OnEnable()
    {
        EventManager.shootEnemy += Shooting;
    }

    private void OnDisable()
    {
        EventManager.shootEnemy -= Shooting;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            HP--;
            if (HP < 0)
            {
                TextFloat textFloat = Instantiate(moneyText, other.transform.position, Quaternion.identity).GetComponent<TextFloat>();
                textFloat.SetCountText(money);
                Score.Instance.UpScore(money);

                Instantiate(deathPart, other.transform.position, Quaternion.identity);

                EventManager.OnDeathEnemy(index);
                Destroy(gameObject);
            }
        }
    }

    public void Shooting()
    {
        Shoot(firePoint);
        Shoot(firePoint1);
        Shoot(firePoint2);
        Shoot(firePoint3);
        Shoot(firePoint4);
    }
    public void Shoot(Transform firePoint)
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
    }
    public void SoundEnemy()
    {
        //if (index == 0)
        //{
        //    SoundManager.Instance.bobr.Play();
        //}
        //if (index == 58)
        //{
        //    SoundManager.Instance.capuchino.Play();
        //}
        //if (index == 59)
        //{
        //    SoundManager.Instance.dinDon.Play();
        //}
        //if (index == 60)
        //{
        //    SoundManager.Instance.fish.Play();
        //}
        //if (index == 61)
        //{
        //    SoundManager.Instance.lagushka.Play();
        //}
        //if (index == 62)
        //{
        //    SoundManager.Instance.crocodilo.Play();
        //}
        //if (index == 63)
        //{
        //    SoundManager.Instance.monkey.Play();
        //}
        //if (index == 64)
        //{
        //    SoundManager.Instance.duck.Play();
        //}
        //if (index == 65)
        //{
        //    SoundManager.Instance.katFish.Play();
        //}
        //if (index == 66)
        //{
        //    SoundManager.Instance.osminog.Play();
        //}
        //if (index == 67)
        //{
        //    SoundManager.Instance.shark.Play();
        //}
        //if (index == 68)
        //{
        //    SoundManager.Instance.monkeyNose.Play();
        //}
        //if (index == 69)
        //{
        //    SoundManager.Instance.arbuz.Play();
        //}
    }
}
