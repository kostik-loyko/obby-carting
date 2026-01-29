using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class Trash : MonoBehaviour
{
    [SerializeField] GameObject treeObj;
    int HP = 2;
    int damage = 1;
    float money = 2000;
    [SerializeField] GameObject treePart;

    public void CutTrash()
    {
        HP -= damage;
        SoundManager.Instance.trashHit.Play();

        if (HP < 0)
        {
            Score.Instance.UpScore(money);
            PlayerBehavior.Instance.TakeMoney(money);

            FirstHelp.Instance.ChangeIsDesroy(1);

            Instantiate(treePart, transform.position, Quaternion.identity);
            Destroy(treeObj);
        }
    }
}
