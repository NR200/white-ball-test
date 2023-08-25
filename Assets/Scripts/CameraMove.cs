using UnityEngine;
/// <summary>
/// Данный класс отвечает за движение камеры по горизонтали
/// </summary>
public class CameraMove : MonoBehaviour
{
    [SerializeField] float _speed; //скорость движения

    void Update()

    {
        transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}
