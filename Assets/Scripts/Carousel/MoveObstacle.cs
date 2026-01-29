using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    private bool tuoch = false;

    //[SerializeField] DoorMove doorMove1;
    //[SerializeField] DoorMove doorMove2;

    private float speed = 5f;
    private float amplitude = 5f;
    private float frequency = 0.5f;
    private float frequency1 = 2f;

    private Vector3 startPosition;
    private Vector3 startPosition1;
    private float time = 0f;
    private float counter = 0f;
    private bool toggle = true;

    [SerializeField] GameObject platformUp;
    [SerializeField] GameObject panel1;
    [SerializeField] GameObject panel2;
    [SerializeField] GameObject panel3;
    [SerializeField] GameObject panel4;

    [SerializeField] GameObject brevnoShipi;
    [SerializeField] GameObject brevnoShipi1;
    [SerializeField] GameObject cubeRotate;
    [SerializeField] GameObject cubeRotate1;
    [SerializeField] GameObject cubeRotate2;
    [SerializeField] GameObject cubeRotate3;
    [SerializeField] GameObject brevna;
    [SerializeField] GameObject brevna1;
    [SerializeField] GameObject brevna2;
    [SerializeField] GameObject brevna3;
    //[SerializeField] GameObject swat;

    //[SerializeField] GameObject jumper;

    private MaterialPropertyBlock _propBlock;
    public Vector2 scrollDirection = new Vector2(1, 0);
    public float scrollSpeed = 0.1f;
    //[SerializeField] GameObject elevator1;

    void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
    }

    private void Start()
    {
        startPosition = platformUp.transform.position;
        //startPosition1 = jumper.transform.position;
    }
    private void FixedUpdate()
    {
        RotateObj();
        MoveSine();
        MoveLinear();

        //doorMove1.ChangeDoor();
        //doorMove2.ChangeDoor();

        //MovingTexture(elevator1);
    }
    private void OnEnable()
    {
        EventManager.touchPlatformOn += TuochON;
        EventManager.touchPlatformOff += TuochOFF;
    }
    private void OnDisable()
    {
        EventManager.touchPlatformOn -= TuochON;
        EventManager.touchPlatformOff -= TuochOFF;
    }
    public void TuochON()
    {
        tuoch = true;
    }
    public void TuochOFF()
    {
        tuoch = false;
    }
    public void RotateObj()
    {
        brevnoShipi.transform.Rotate(0, 0.4f, 0);
        brevnoShipi1.transform.Rotate(0, 0.4f, 0);
        cubeRotate.transform.Rotate(0, -0.4f, 0);
        cubeRotate1.transform.Rotate(0, -0.4f, 0);
        cubeRotate2.transform.Rotate(0, -0.4f, 0);
        cubeRotate3.transform.Rotate(0, 0.6f, 0);
        brevna.transform.Rotate(0, 0.8f, 0);
        brevna1.transform.Rotate(0, 0.8f, 0);
        brevna2.transform.Rotate(0, 0.8f, 0);
        brevna3.transform.Rotate(0, 0.8f, 0);
        //swat.transform.Rotate(0, 1f, 0);
    }
    public void MoveSine()
    {
        time += Time.deltaTime;
        float xOffset = amplitude * Mathf.Sin(frequency * time);
        platformUp.transform.position = startPosition + new Vector3(0, xOffset, 0);
        float xOffset1 = amplitude * Mathf.Sin(frequency1 * time);
        //jumper.transform.position = startPosition1 + new Vector3(0, xOffset1, 0);
    }
    void MoveLinear()
    {
        if (counter > 10)
        {
            toggle = false;
        }
        if (counter < 0)
        {
            toggle = true;
        }

        if (toggle)
        {
            counter += Time.deltaTime;
            if (counter < 5)
            {
                panel1.transform.Translate(Vector3.right * speed * Time.deltaTime);
                panel2.transform.Translate(Vector3.right * speed * Time.deltaTime);
                panel3.transform.Translate(Vector3.right * speed * Time.deltaTime);
                panel4.transform.Translate(Vector3.right * speed * Time.deltaTime);
                if (tuoch)
                {
                    characterController.enabled = false;
                }
            }
            else
            {
                panel1.transform.position = panel1.transform.position;
                panel2.transform.position = panel2.transform.position;
                panel3.transform.position = panel3.transform.position;
                panel4.transform.position = panel4.transform.position;
                characterController.enabled = true;
            }
        }
        if (!toggle)
        {
            counter -= Time.deltaTime;
            if (counter > 5)
            {
                panel1.transform.Translate(Vector3.left * speed * Time.deltaTime);
                panel2.transform.Translate(Vector3.left * speed * Time.deltaTime);
                panel3.transform.Translate(Vector3.left * speed * Time.deltaTime);
                panel4.transform.Translate(Vector3.left * speed * Time.deltaTime);
                if (tuoch)
                {
                    characterController.enabled = false;
                }
            }
            else
            {
                panel1.transform.position = panel1.transform.position;
                panel2.transform.position = panel2.transform.position;
                panel3.transform.position = panel3.transform.position;
                panel4.transform.position = panel4.transform.position;
                characterController.enabled = true;
            }
        }
    }
    public void MovingTexture(GameObject elevator)
    {
        print("JJJJJJJJJJJJJJJJJJJJJJJJJ");
        Renderer renderer = elevator.GetComponent<Renderer>();
        renderer.GetPropertyBlock(_propBlock); // Получить текущие свойства

        Vector4 texST = renderer.material.GetVector("_MainTex_ST"); // Получить текущее смещение
        texST.x += scrollDirection.x * scrollSpeed * Time.deltaTime;
        texST.y += scrollDirection.y * scrollSpeed * Time.deltaTime;
        _propBlock.SetVector("_MainTex_ST", texST); // Установить новое смещение

        renderer.SetPropertyBlock(_propBlock); // Применить измененные свойства
    }
}
