using UnityEngine;
/// <summary>
/// Данный класс отвечает за поведения препятсвия: перемещение между заданными кординатами
/// </summary>
public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] Transform _pos1, _pos2; //ссылки на кординаты позиций
    Transform _startPos; //стартовая позиция

    [SerializeField] float _speed;//скорость движения

    Vector3 _nextPos;

    void Start()

    {
        int i = Random.Range(1, 4);
        if (i < 3)
            _startPos = _pos1;
        if (i > 2)
            _startPos = _pos2;

        _nextPos = _startPos.position; 

        Destroy(gameObject, 20.0f); // уничтожаем объект через 20 секунд
    }

    void Update()
    { //перемещаем объект от стартовой позиции, пока не достигент заданой позиции, после чего возвращаем его
        if (transform.position == _pos1.position) 
            _nextPos = _pos2.position;

        if (transform.position == _pos2.position)
            _nextPos = _pos1.position;

        transform.position = Vector3.MoveTowards(transform.position, _nextPos, _speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(_pos1.position, _pos2.position); //отображение перемещения для отладки
    }

    
}
