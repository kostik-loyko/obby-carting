using UnityEngine;

public class PetController : MonoBehaviour
{

    Transform player; // Ссылка на Transform игрока
    [SerializeField] float followDistance = 3f; // Минимальное расстояние
    float moveSpeed = 5f; // Скорость преследования

    void Start()
    {
        player = FindObjectOfType<GrowNeck>().transform;
    }
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        // Если объект находится дальше минимального расстояния
        if (distance > followDistance)
        {
            // Определяем целевую позицию, сохраняя высоту игрока
            Vector3 targetPosition = new Vector3(player.position.x, player.position.y, player.position.z);
            // Если мы слишком близко по X/Z, не двигаемся, но сохраняем высоту игрока.
            // Лучше сделать проверку расстояния и двигать, пока не достигнет 'followDistance'

            // Движемся к цели, но только в плоскости XZ (горизонтально), высота игрока
            // Мы уже используем y-координату игрока в `targetPosition`,
            // но если объект хочет оставаться строго на высоте игрока, а игрок летает, это сработает.

            // Для более точного преследования на расстоянии 2 метра и той же высоте
            //Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Мы хотим стоять на высоте игрока, но с отступом по Z (или X).
            // Допустим, мы стоим ЗА игроком на расстоянии 2 метра
            Vector3 desiredOffset = player.forward * -followDistance; // Отступ позади игрока
            Vector3 desiredPosition = player.position + desiredOffset;

            // Устанавливаем Y-координату равной высоте игрока
            desiredPosition.y = player.position.y;

            // Двигаемся к этой желаемой позиции, но не приближаемся ближе 2 метров
            // Вместо этого, мы двигаем объект так, чтобы он не был ближе 2 метров,
            // но при этом сохранял высоту.

            // Давайте использовать Vector3.Lerp для плавности, если нужно
            // transform.position = Vector3.Lerp(transform.position, desiredPosition, moveSpeed * Time.deltaTime);

            // Или MoveTowards, чтобы точно дойти до позиции
            transform.position = Vector3.MoveTowards(transform.position, desiredPosition, moveSpeed * Time.deltaTime);

        }

        transform.position = new Vector3(transform.position.x, player.position.y - 1, transform.position.z);

        // Опционально: Поворот к игроку
        transform.LookAt(player.position); // Поворачивает объект к игроку
    }
}

