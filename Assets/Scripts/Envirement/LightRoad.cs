using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class LightRoad : MonoBehaviour
{
    [SerializeField] GameObject treeObj;
    int HP = 2;
    int damage = 1;
    float money = 2000;
    [SerializeField] GameObject treePart;

    public void CutLightRoad()
    {
        HP -= damage;
        SoundManager.Instance.lightHit.Play();

        if (HP < 0)
        {
            Score.Instance.UpScore(money);
            PlayerBehavior.Instance.TakeMoney(money);

            FirstHelp.Instance.ChangeIsDesroy(2);

            Instantiate(treePart, transform.position, Quaternion.identity);
            Destroy(treeObj);
        }
    }
}
