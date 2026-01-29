using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    //[SerializeField] GameObject treeObj;
    int HP = 0;
    int damage = 1;
    float money = 200;
    //[SerializeField] GameObject hitPart;
    //[SerializeField] GameObject treePart;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            HP -= damage;

            //Instantiate(hitPart, collision.gameObject.transform.position, Quaternion.identity);

            SoundManager.Instance.egg.Play();

            if (HP < 0)
            {
                Score.Instance.UpScore(money);
                PlayerBehavior.Instance.TakeMoney(money);
            }
        }
    }
}
