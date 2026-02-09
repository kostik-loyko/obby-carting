using System.Collections.Generic;
using UnityEngine;
using YG;

public class PetNew : MonoBehaviour
{
    public static PetNew Instance { get; set; }
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

    public int currentPetIndexNew;
    public bool hasPetsNew = false;

    public GameObject[] pets;
    List<GameObject> PoolPets = new List<GameObject>();
    [SerializeField] GameObject player;
    [SerializeField] private Transform[] petInsideObj;
    
    [SerializeField] MoveTop _moveTop;
    [SerializeField] GameObject[] hidePets;

    void Start()
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
        currentPetIndexNew = YandexGame.savesData.currentPetIndexNew;

        hasPetsNew = YandexGame.savesData.hasPetsNew;

        if (hasPetsNew)
        {
            PickPets(currentPetIndexNew);
        }
    }
    public void PickPets(int indexPet)
    {
        if (PoolPets.Count > 0)
        {
            Destroy(PoolPets[0]);
            PoolPets.Remove(PoolPets[0]);
        }

        Vector3 posPet = new(0, 0, -3);
        GameObject NewPet = Instantiate(pets[indexPet], player.transform.position + posPet, Quaternion.identity);
        
        //NewPet.GetComponent<ObgectController>().enabled = false;
        petInsideObj = NewPet.GetComponentsInChildren<Transform>();
        for (int i = 0; i < petInsideObj.Length; i++)
        {
            if (i != 0)
            {
                Destroy(petInsideObj[i].transform.gameObject);
            }
        }
        PoolPets.Add(NewPet);

        hasPetsNew = true;

        _moveTop.SetBonusRevenuePet(indexPet);

        YandexGame.savesData.hasPetsNew = hasPetsNew;
        YandexGame.SaveProgress();
    }
    public void ShowNewPets(int currIndex)
    {
        for (int i = 0; i < hidePets.Length; i++)
        {
            if (i == currIndex && currIndex != hidePets.Length - 1)
            {
                if (hidePets[i + 1] != null)
                {
                    hidePets[i + 1].SetActive(false);
                }
            }
        }
    }
}
