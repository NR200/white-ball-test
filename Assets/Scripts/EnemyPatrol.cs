using UnityEngine;
/// <summary>
/// ������ ����� �������� �� ��������� ����������: ����������� ����� ��������� �����������
/// </summary>
public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] Transform _pos1, _pos2; //������ �� ��������� �������
    Transform _startPos; //��������� �������

    [SerializeField] float _speed;//�������� ��������

    Vector3 _nextPos;

    void Start()

    {
        int i = Random.Range(1, 4);
        if (i < 3)
            _startPos = _pos1;
        if (i > 2)
            _startPos = _pos2;

        _nextPos = _startPos.position; 

        Destroy(gameObject, 20.0f); // ���������� ������ ����� 20 ������
    }

    void Update()
    { //���������� ������ �� ��������� �������, ���� �� ��������� ������� �������, ����� ���� ���������� ���
        if (transform.position == _pos1.position) 
            _nextPos = _pos2.position;

        if (transform.position == _pos2.position)
            _nextPos = _pos1.position;

        transform.position = Vector3.MoveTowards(transform.position, _nextPos, _speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(_pos1.position, _pos2.position); //����������� ����������� ��� �������
    }

    
}
