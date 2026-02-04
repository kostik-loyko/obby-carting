using GLTFast.Schema;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class ControllerMobile : MonoBehaviour
{
    public static ControllerMobile Instance { get; set; }
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
        playerInput = new Player();
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }
    private CharacterController controller;
    Rigidbody rb;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private bool isShootState;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -9.81f;
    //private float rotationSpeed = 4f;
    private Player playerInput;
    private Transform cameraMain;
    //public Transform child;
    [SerializeField] private Transform weapon;
    [SerializeField] private Animator _animator;
    [SerializeField] MoveTop moveTop;
    [SerializeField] Image modeIcon;
    //[SerializeField] Sprite modeRun;
    //[SerializeField] Sprite modeShoot;

    private Vector3 lastPosition;

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    private void Start()
    {
        cameraMain = UnityEngine.Camera.main.transform;

        lastPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (GameManager.Instance.PauseGame())
        {
            return;
        }
        if (moveTop.CanMoveTop())
        {
            controller.enabled = false;
            rb.isKinematic = true;
            _animator.SetBool("run", false);
            return;
        }
        else
        {
            controller.enabled = true;
            rb.isKinematic = false;
        }
        controller.enabled = true;
        rb.isKinematic = false;
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();
        Vector3 move = (cameraMain.forward * movementInput.y + cameraMain.right * movementInput.x);
        move.y = 0f;
        controller.Move(move * Time.deltaTime * (playerSpeed + PlayerBehavior.Instance.velocity));

        if (move != Vector3.zero && !isShootState)
        {
            gameObject.transform.forward = move;
            RotationSkin();
        }

        //if (BranrotManager.Instance.TakeCatchBrabrotBool())
        //{
        //    _animator.SetBool("handrun", controller.velocity.magnitude > 0f);
        //}
        //else
        //{
        //    _animator.SetBool("run", controller.velocity.magnitude > 0f);
        //}
        _animator.SetBool("run", controller.velocity.magnitude > 0f);

        // Makes the player jump
        if (playerInput.PlayerMain.Jump.triggered && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
            SoundManager.Instance.jump.Play();
        }
        _animator.SetBool("air", playerInput.PlayerMain.Jump.triggered);

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        //if (movementInput != Vector2.zero && isShootState)
        //{
        //    Quaternion rotation = Quaternion.Euler(new Vector3(child.localEulerAngles.x, cameraMain.localEulerAngles.y, child.localEulerAngles.z));
        //    child.rotation = Quaternion.Lerp(child.rotation, rotation, Time.deltaTime * rotationSpeed);
        //    weapon.rotation = Quaternion.Lerp(child.rotation, rotation, Time.deltaTime * rotationSpeed);
        //    //inventori.rotation = Quaternion.Lerp(weapon.rotation, rotation, Time.deltaTime * rotationSpeed);
        //}

        //if (SimpleInput.GetButtonDown("isShoot"))
        //{
        //    isShootState = !isShootState;
        //    if (isShootState)
        //    {
        //        modeIcon.sprite = modeShoot;
        //    } else
        //    {
        //        modeIcon.sprite = modeRun;
        //    }
        //}
    }
    //public void ChangeChild(int index)
    //{
    //    child = GameManager.Instance.personSkins[index].transform;
    //}

    public void RotationSkin()
    {
        Vector3 movement = transform.position - lastPosition;
        Vector3 direction = movement.normalized;
        lastPosition = transform.position;
        if (direction.magnitude > 0.001f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            //child.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            //weapon.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
    //public void ToggleShootMode()
    //{
    //    isShootState = !isShootState;
    //    if (isShootState)
    //    {
    //        modeIcon.sprite = modeShoot;
    //    }
    //    else
    //    {
    //        modeIcon.sprite = modeRun;
    //    }
    //}
}
