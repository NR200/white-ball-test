using UnityEngine;
/// <summary>
/// Данный класс отвечает за перемещение ограничивающей стены
/// </summary>
public class ObjectMove : MonoBehaviour
{
    [SerializeField] float _speed;

    void Update()

    {
        transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}
