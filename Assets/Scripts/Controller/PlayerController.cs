using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; set; }
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
    [SerializeField] GameObject player;
    public Transform cameraPosition;
    public MobileInputManager InputManager;
    [Header("Настройки управления")] public float mouseSensitivity = 5.0f; // Чувствительность мыши.
    //public float playerSpeed = 5f; // Скорость движения персонажа.
    public float jumpHeight = 3.5f; // Высота прыжка.

    private float verticalAngle = 0.0f;
    public float horizontalAngle = 0.0f; // НЕ УДАЛЯТЬ! ПЕРЕКЛЮЧАЕТ КАМЕРУ ОТ 3-ГО И 1-ГО ЛИЦА НА ДЕСКТОПЕ

    private float verticalSpeed = 0.0f;

    public CharacterController characterController;
    [SerializeField] private Animator _animator;
    [SerializeField] private Animator animHammer;

    public GameObject thirdCamera;
    public GameObject firstCamera;

    //public bool isPunch = false; // костыль чтобы небыло войного удара киркой (всёравно иногда бывает)
    public bool weapon1 = true;
    public bool weapon2 = false;
    public bool weapon3 = false;
    [SerializeField] GameObject hammer;
    [SerializeField] GameObject gun;
    [SerializeField] GameObject poop;
    [SerializeField] GameObject border1;
    [SerializeField] GameObject border2;
    [SerializeField] GameObject border3;

    void Update()
    {
        if (GameManager.Instance.PauseGame())
        {
            return;
        }
        //PetManager.Instance.GetPet();
        //ToggleCamera();
        //if (Portal.Instance.CanShoot())
        //{
        //    ToggleWeapon();
        //    ControllerWeapon();
        //}
    }

    public void AttackHammer()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !MobileInputManager.Instance.IsMobileDevice() && 
            GameManager.Instance.punchEnanle)
        {
            //isPunch = true;
            animHammer.SetBool("punch", true);
            PuhchOff();
        }
        if (SimpleInput.GetButtonDown("Punch") &&
            GameManager.Instance.punchEnanle)
        {
            //isPunch = true;
            animHammer.SetBool("punch", true);
            PuhchOff();
        }
    }
    public void PuhchOff()
    {
        StartCoroutine(WaitPuhchOff());
    }
    private IEnumerator WaitPuhchOff()
    {
        yield return new WaitForSeconds(0.25f);
        animHammer.SetBool("punch", false);
        //isPunch = false;
    }
    public void ToggleCamera()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && !MobileInputManager.Instance.IsMobileDevice())
        {
            player.GetComponent<ThirdPersonController>().enabled = false;
            player.GetComponent<FPC>().enabled = true;
            thirdCamera.SetActive(false);
            firstCamera.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1) && !MobileInputManager.Instance.IsMobileDevice())
        {
            player.GetComponent<FPC>().enabled = false;
            player.GetComponent<ThirdPersonController>().enabled = true;
            firstCamera.SetActive(false);
            thirdCamera.SetActive(true);
        }
    }
    public void ToggleWeapon()
    {
        if (!MobileInputManager.Instance.IsMobileDevice())
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                weapon1 = true;
                weapon2 = false;
                weapon3 = false;
                SoundManager.Instance.select.Play();
            }
            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                weapon1 = false;
                weapon2 = true;
                weapon3 = false;
                SoundManager.Instance.select.Play();
            }
            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                weapon1 = false;
                weapon2 = false;
                weapon3 = true;
                SoundManager.Instance.select.Play();
            }
        } else
        {
            if (SimpleInput.GetButtonDown("weapon1"))
            {
                weapon1 = true;
                weapon2 = false;
                weapon3 = false;
                SoundManager.Instance.select.Play();
            }
            if (SimpleInput.GetButtonDown("weapon2"))
            {
                weapon1 = false;
                weapon2 = true;
                weapon3 = false;
                SoundManager.Instance.select.Play();
            }
            if (SimpleInput.GetButtonDown("weapon3"))
            {
                weapon1 = false;
                weapon2 = false;
                weapon3 = true;
                SoundManager.Instance.select.Play();
            }
        }

    }
    public void ControllerWeapon()
    {
        if (weapon1 == true)
        {
            hammer.SetActive(true);
            gun.SetActive(false);
            poop.SetActive(false);
            border1.SetActive(true);
            border2.SetActive(false);
            border3.SetActive(false);
            AttackHammer();
        }
        else if (weapon2 == true)
        {
            hammer.SetActive(false);
            gun.SetActive(true);
            poop.SetActive(false);
            border1.SetActive(false);
            border2.SetActive(true);
            border3.SetActive(false);
            Shooting.Instance.ShootingGun();
        }
        else if (weapon3 == true)
        {
            hammer.SetActive(false);
            gun.SetActive(false);
            poop.SetActive(true);
            border1.SetActive(false);
            border2.SetActive(false);
            border3.SetActive(true);
            ShootingPoop.Instance.ShootPoop();
        }
    }
}