using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class Wall : MonoBehaviour
{
    [SerializeField] int indexWall;
    [SerializeField] GameObject objWall;
    [SerializeField] int maxHP;
    int HP;
    [SerializeField] TextMeshProUGUI textHP;
    [SerializeField] TextMeshProUGUI textMaxHP;

    [SerializeField] GameObject hitPart;
    [SerializeField] GameObject wallPart;
    [SerializeField] GameObject pet;

    bool isFirstGetload = true;
    bool isDestoyWall = false;

    private void Start()
    {
        if (YandexGame.SDKEnabled == true)
        {
            GetLoad();
        }
    }
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void GetLoad()
    {
        if (indexWall == 0)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        } 
        else if (indexWall == 1)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 2)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 3)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 4)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 5)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 6)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 7)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 8)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 9)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 10)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 11)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 12)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 13)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 14)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 15)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 16)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 17)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 18)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 19)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 20)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 21)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }
        else if (indexWall == 22)
        {
            isDestoyWall = YandexGame.savesData.walls[indexWall];
        }

        if (isDestoyWall && isFirstGetload)
        {
            isFirstGetload = false;
            Destroy(objWall);
        } else
        {
            HP = maxHP;
            textHP.text = ShortScaleString.parseFloat(HP, 1, 1000, true).ToString();
            textMaxHP.text = ShortScaleString.parseFloat(HP, 1, 1000, true).ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Glove"))
        {
            HP -= Damage.Instance.damage;

            objWall.transform.localScale = new Vector3(0.99f, 0.99f, 0.99f);
            StartCoroutine(BackScaleObjects());

            //Vector3 posParticle = new Vector3(0, 0, 0);
            Instantiate(hitPart, other.gameObject.transform.position, Quaternion.identity);

            textHP.text = ShortScaleString.parseFloat(HP, 1, 1000, true).ToString();
            PlayerBehavior.Instance.GetDamageText(Damage.Instance.damage);
            SoundManager.Instance.egg.Play();

            if (HP < 0)
            {
                float upScore = Score.Instance.GetRateFinalForWall(maxHP);
                Score.Instance.UpScore(upScore);
                PlayerBehavior.Instance.TakeMoney(upScore);
                isDestoyWall = true;
                textHP.text = 0.ToString();

                Vector3 changePosition = new Vector3(0, 0, 0);
                Instantiate(wallPart, transform.position, Quaternion.identity);
                GameObject NewPet = Instantiate(pet, transform.position + changePosition, Quaternion.identity);
                //NewPet.GetComponent<PetController>().enabled = false; убрал т.к. новый контроллер питомца
                NewPet.GetComponent<PetBonus>().enabled = false;
                
                SaveWall();
                Destroy(objWall);
            }
        }
    }
    public void CutEgg()
    {
        HP -= Damage.Instance.damage;

        objWall.transform.localScale = new Vector3(0.99f, 0.99f, 0.99f);
        StartCoroutine(BackScaleObjects());

        //Vector3 posParticle = new Vector3(0, 0, 0);
        //Instantiate(hitPart, other.gameObject.transform.position, Quaternion.identity);

        textHP.text = ShortScaleString.parseFloat(HP, 1, 1000, true).ToString();
        PlayerBehavior.Instance.GetDamageText(Damage.Instance.damage);
        SoundManager.Instance.egg.Play();

        if (HP < 0)
        {
            float upScore = Score.Instance.GetRateFinalForWall(maxHP);
            Score.Instance.UpScore(upScore);
            PlayerBehavior.Instance.TakeMoney(upScore);
            isDestoyWall = true;
            textHP.text = 0.ToString();

            Vector3 changePosition = new Vector3(0, 0, 0);
            Instantiate(wallPart, transform.position, Quaternion.identity);
            GameObject NewPet = Instantiate(pet, transform.position + changePosition, Quaternion.identity);
            //NewPet.GetComponent<PetController>().enabled = false;
            NewPet.GetComponent<PetBonus>().enabled = false;
            SaveWall();
            Destroy(objWall);
        }
    }
    private void SaveWall()
    {
        if (indexWall == 0)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        } 
        else if (indexWall == 1) 
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 2)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 3)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 4)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 5)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 6)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 7)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 8)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 9)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 10)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 11)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 12)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 13)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 14)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 15)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 16)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 17)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 18)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 19)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 20)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 21)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
        else if (indexWall == 22)
        {
            YandexGame.savesData.walls[indexWall] = isDestoyWall;
        }
    }
    private IEnumerator BackScaleObjects()
    {
        yield return new WaitForSeconds(0.1f);
        objWall.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}