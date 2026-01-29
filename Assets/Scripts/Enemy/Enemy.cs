using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;

    [SerializeField] GameObject deathPart;
    [SerializeField] GameObject moneyText;
    int HP = 5;
    [SerializeField] int index;
    float money = 4000f;
    float bulletForce = 18f;

    private void OnEnable()
    {
        EventManager.shootEnemy += Shoot;
    }

    private void OnDisable()
    {
        EventManager.shootEnemy -= Shoot;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            HP--;
            if (HP < 0)
            {
                //Vector3 posMoney = new Vector3(0, 5, 0);
                TextFloat textFloat = Instantiate(moneyText, other.transform.position, Quaternion.identity).GetComponent<TextFloat>();
                textFloat.SetCountText(money);
                Score.Instance.UpScore(money);

                Instantiate(deathPart, other.transform.position, Quaternion.identity);
                SoundManager.Instance.back.volume = 1f;

                EventManager.OnDeathEnemy(index);
                Destroy(gameObject);
            }
        }
        if (other.gameObject.CompareTag("Grenade"))
        {
            HP=-5;
            if (HP < 0)
            {
                //Vector3 posMoney = new Vector3(0, 5, 0);
                TextFloat textFloat = Instantiate(moneyText, other.transform.position, Quaternion.identity).GetComponent<TextFloat>();
                textFloat.SetCountText(money);
                Score.Instance.UpScore(money);

                Instantiate(deathPart, other.transform.position, Quaternion.identity);
                SoundManager.Instance.back.volume = 1f;

                EventManager.OnDeathEnemy(index);
                Destroy(gameObject);
            }
        }
    }
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
    }
    public void SoundEnemy()
    {
        SoundManager.Instance.zombiStart.Play();
        //if (index == 0)
        //{
        //    SoundManager.Instance.bobr.Play();
        //}
        //if (index == 1)
        //{
        //    SoundManager.Instance.capuchino.Play();
        //}
        //if (index == 2)
        //{
        //    SoundManager.Instance.cocos.Play();
        //}
        //if (index == 3)
        //{
        //    SoundManager.Instance.dinDon.Play();
        //}
        //if (index == 4)
        //{
        //    SoundManager.Instance.fish.Play();
        //}
        //if (index == 5)
        //{
        //    SoundManager.Instance.crocodilo.Play();
        //}
        //if (index == 6)
        //{
        //    SoundManager.Instance.lagushka.Play();
        //}
        //if (index == 7)
        //{
        //    SoundManager.Instance.cocos.Play();
        //}
        //if (index == 8)
        //{
        //    SoundManager.Instance.monkey.Play();
        //}
        //if (index == 9)
        //{
        //    SoundManager.Instance.duck.Play();
        //}
        //if (index == 10)
        //{
        //    SoundManager.Instance.katFish.Play();
        //}
        //if (index == 11)
        //{
        //    SoundManager.Instance.osminog.Play();
        //}
        //if (index == 12)
        //{
        //    SoundManager.Instance.shark.Play();
        //}
        //if (index == 13)
        //{
        //    SoundManager.Instance.monkeyNose.Play();
        //}
        //if (index == 14)
        //{
        //    SoundManager.Instance.arbuz.Play();
        //}
        //if (index == 15)
        //{
        //    SoundManager.Instance.elefant.Play();
        //}
        //if (index == 16)
        //{
        //    SoundManager.Instance.delfini.Play();
        //}
        //if (index == 17)
        //{
        //    SoundManager.Instance.tigr.Play();
        //}
        //if (index == 18)
        //{
        //    SoundManager.Instance.camel.Play();
        //}
        //if (index == 19)
        //{
        //    SoundManager.Instance.bobr.Play();
        //}
        //if (index == 20)
        //{
        //    SoundManager.Instance.capuchino.Play();
        //}
        //if (index == 21)
        //{
        //    SoundManager.Instance.cocos.Play();
        //}
        //if (index == 22)
        //{
        //    SoundManager.Instance.dinDon.Play();
        //}
        //if (index == 23)
        //{
        //    SoundManager.Instance.fish.Play();
        //}
        //if (index == 24)
        //{
        //    SoundManager.Instance.crocodilo.Play();
        //}
        //if (index == 25)
        //{
        //    SoundManager.Instance.lagushka.Play();
        //}
        //if (index == 26)
        //{
        //    SoundManager.Instance.cocos.Play();
        //}
        //if (index == 27)
        //{
        //    SoundManager.Instance.monkey.Play();
        //}
        //if (index == 28)
        //{
        //    SoundManager.Instance.duck.Play();
        //}
        //if (index == 29)
        //{
        //    SoundManager.Instance.katFish.Play();
        //}
        //if (index == 30)
        //{
        //    SoundManager.Instance.osminog.Play();
        //}
        //if (index == 31)
        //{
        //    SoundManager.Instance.shark.Play();
        //}
        //if (index == 32)
        //{
        //    SoundManager.Instance.monkeyNose.Play();
        //}
        //if (index == 33)
        //{
        //    SoundManager.Instance.arbuz.Play();
        //}
        //if (index == 34)
        //{
        //    SoundManager.Instance.elefant.Play();
        //}
        //if (index == 35)
        //{
        //    SoundManager.Instance.capuchino.Play();
        //}
        //if (index == 36)
        //{
        //    SoundManager.Instance.tigr.Play();
        //}
        //if (index == 37)
        //{
        //    SoundManager.Instance.camel.Play();
        //}
        //if (index == 38)
        //{
        //    SoundManager.Instance.bobr.Play();
        //}
        //if (index == 39)
        //{
        //    SoundManager.Instance.capuchino.Play();
        //}
        //if (index == 40)
        //{
        //    SoundManager.Instance.cocos.Play();
        //}
        //if (index == 41)
        //{
        //    SoundManager.Instance.dinDon.Play();
        //}
        //if (index == 42)
        //{
        //    SoundManager.Instance.fish.Play();
        //}
        //if (index == 43)
        //{
        //    SoundManager.Instance.crocodilo.Play();
        //}
        //if (index == 44)
        //{
        //    SoundManager.Instance.lagushka.Play();
        //}
        //if (index == 45)
        //{
        //    SoundManager.Instance.cocos.Play();
        //}
        //if (index == 46)
        //{
        //    SoundManager.Instance.monkey.Play();
        //}
        //if (index == 47)
        //{
        //    SoundManager.Instance.duck.Play();
        //}
        //if (index == 48)
        //{
        //    SoundManager.Instance.katFish.Play();
        //}
        //if (index == 49)
        //{
        //    SoundManager.Instance.osminog.Play();
        //}
        //if (index == 50)
        //{
        //    SoundManager.Instance.shark.Play();
        //}
        //if (index == 51)
        //{
        //    SoundManager.Instance.monkeyNose.Play();
        //}
        //if (index == 52)
        //{
        //    SoundManager.Instance.arbuz.Play();
        //}
        //if (index == 53)
        //{
        //    SoundManager.Instance.elefant.Play();
        //}
        //if (index == 54)
        //{
        //    SoundManager.Instance.delfini.Play();
        //}
        //if (index == 55)
        //{
        //    SoundManager.Instance.tigr.Play();
        //}
        //if (index == 56)
        //{
        //    SoundManager.Instance.camel.Play();
        //}
        //if (index == 57)
        //{
        //    SoundManager.Instance.fish.Play();
        //}
    }
}
