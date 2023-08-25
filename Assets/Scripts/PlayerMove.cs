using UnityEngine;
/// <summary>
/// ƒанный класс отвечает за движение игрока
/// </summary>
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _force;
    [SerializeField] Transform _startPos;

    [SerializeField] float _speed;

    private Rigidbody2D _rigidbody;
   
    void Awake()

    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
   
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        _rigidbody.AddForce(Vector2.up * (_force - _rigidbody.velocity.y), ForceMode2D.Impulse);

        _rigidbody.MoveRotation(_rigidbody.velocity.y * 2.0F);

        transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}
