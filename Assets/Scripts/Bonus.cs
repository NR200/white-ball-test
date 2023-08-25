using UnityEngine;
/// <summary>
/// Данный класс отвечает за поведение бонуса: перемещение за игроком, а так же уничтожения после подбора
/// </summary>
public class Bonus : MonoBehaviour
{
    [SerializeField] float _speed; // скорость перемещения

    Transform _player; //ссылка на кординаты игрока
    bool _follow; //флаг отслеживания кординат игрока

    private void Start()
    {
        Destroy(gameObject, 20.0f);//уничтожения объекта через 20 секунд
    }
    //обработка событий тригера для отслеживания
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
            _follow = true;
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
            _follow = false;
    }
    //обработка события "столкновения" с игроком
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            DestroyBonus();
    }

    private void Update()
    {
        //пока флаг активен, объект следует за игроком
        if(_follow)
        {
            _player = GameObject.Find("Player").transform;

            Vector3 delta = transform.position - _player.position;
            delta.Normalize();
            float moveSpeed = _speed * Time.deltaTime;
            transform.position = transform.position - (delta * moveSpeed);
        }
    }
    // метод уничтожения бонуса
    public void DestroyBonus()
    {
        Destroy(gameObject); 
    }
}
