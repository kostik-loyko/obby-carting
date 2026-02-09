using UnityEngine;
using YG;

public class Pets : MonoBehaviour
{
    public static Pets Instance { get; set; }
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

    public int currentPetIndex;
    public bool hasPets = false;

    public GameObject[] pets;
    [SerializeField] MoveTop _moveTop;

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
        currentPetIndex = YandexGame.savesData.currentPetIndex;

        hasPets = YandexGame.savesData.hasPets;

        if (hasPets)
        {
            PickPets(currentPetIndex);
        }
    }
    public void PickPets(int indexPet)
    {
        for (int i = 0; i < pets.Length; i++)
        {
            pets[i].SetActive(false);
        }
        pets[indexPet].SetActive(true);
        hasPets = true;

        _moveTop.SetSpeedPet(indexPet);

        YandexGame.savesData.hasPets = hasPets;
        YandexGame.SaveProgress();
    }
}
