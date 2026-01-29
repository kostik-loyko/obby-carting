using UnityEngine;

public class ObgectController : MonoBehaviour
{
    Transform player;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        if (player != null)
        {
            // Получаем направление к игроку
            Vector3 direction = player.position - transform.position;

            // Обнуляем вертикальную составляющую, чтобы объект не наклонялся
            direction.y = 0;

            // Если направление не нулевое, поворачиваемся
            if (direction != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                // Плавный поворот (необязательно, можно сразу transform.rotation = targetRotation)
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
            }
        }
    }
}
