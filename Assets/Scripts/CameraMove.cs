using UnityEngine;
/// <summary>
/// ������ ����� �������� �� �������� ������ �� �����������
/// </summary>
public class CameraMove : MonoBehaviour
{
    [SerializeField] float _speed; //�������� ��������

    void Update()

    {
        transform.position += Vector3.right * _speed * Time.deltaTime;
    }
}
