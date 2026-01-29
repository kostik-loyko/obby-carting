using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPC : MonoBehaviour
{
    public static FPC Instance { get; set; }
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
    public Transform cameraPosition;
    public MobileInputManager InputManager;
    [Header("Настройки управления")] public float mouseSensitivity = 5.0f; // Чувствительность мыши.
    //public float playerSpeed = 5f; // Скорость движения персонажа.
    public float jumpHeight = 3.5f; // Высота прыжка.

    private float verticalAngle = 0.0f;
    private float horizontalAngle = 0.0f;

    private float verticalSpeed = 0.0f;

    public CharacterController characterController;
    Rigidbody rb;
    [SerializeField] private Animator _animator;
    [SerializeField] Gates portls;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (GameManager.Instance.PauseGame())
        {
            return;
        }
        //if (portls.InPortal())
        //{
        //    characterController.enabled = false;
        //    rb.isKinematic = true;
        //}
        //else
        //{
        //    characterController.enabled = true;
        //    rb.isKinematic = false;
        //}
        HandleMovement();
        HandleMouseLook();
    }

    void HandleMovement()
    {
        float speed = PlayerBehavior.Instance.velocity;

        float moveHorizontal = SimpleInput.GetAxis("Horizontal");
        float moveVertical = SimpleInput.GetAxis("Vertical");


        Vector3 moveDirection = new Vector3(moveHorizontal, 0, moveVertical).normalized;

        if (moveDirection.magnitude > 1.0f)
            moveDirection.Normalize();

        if (characterController.isGrounded)
        {
            _animator.SetBool("run", moveDirection.magnitude > 0.1f);

        }
        else
        {
            _animator.SetBool("air", true);
            _animator.SetBool("run", false);
        }

        moveDirection = transform.TransformDirection(moveDirection);


        moveDirection *= speed * Time.deltaTime;

        if (characterController.isGrounded)
        {
            GameManager.Instance.onGraundForADV = true;
            _animator.SetBool("air", false);
            if (SimpleInput.GetButtonDown("Jump"))
            {
                _animator.SetBool("air", true);
                verticalSpeed = Mathf.Sqrt(2.0f * jumpHeight * Mathf.Abs(Physics.gravity.y));
                GameManager.Instance.onGraundForADV = false;
                SoundManager.Instance.jump.Play();
            }
        }
        else
        {
            _animator.SetBool("air", true);
            GameManager.Instance.onGraundForADV = false;
        }

        verticalSpeed += Physics.gravity.y * Time.deltaTime;
        moveDirection.y = verticalSpeed * Time.deltaTime;
        characterController.Move(moveDirection);
    }

    void HandleMouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = -Input.GetAxis("Mouse Y") * mouseSensitivity;
        PlayerController.Instance.horizontalAngle += mouseX;

        verticalAngle = Mathf.Clamp(verticalAngle + mouseY, -20.0f, 50.0f);

        transform.localRotation = Quaternion.Euler(0.0f, PlayerController.Instance.horizontalAngle, 0.0f);
        cameraPosition.localRotation = Quaternion.Euler(verticalAngle, 0.0f, 0.0f);
    }
}
