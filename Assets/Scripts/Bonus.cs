using UnityEngine;
/// <summary>
/// ������ ����� �������� �� ��������� ������: ����������� �� �������, � ��� �� ����������� ����� �������
/// </summary>
public class Bonus : MonoBehaviour
{
    [SerializeField] float _speed; // �������� �����������

    Transform _player; //������ �� ��������� ������
    bool _follow; //���� ������������ �������� ������

    private void Start()
    {
        Destroy(gameObject, 20.0f);//����������� ������� ����� 20 ������
    }
    //��������� ������� ������� ��� ������������
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
    //��������� ������� "������������" � �������
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
            DestroyBonus();
    }

    private void Update()
    {
        //���� ���� �������, ������ ������� �� �������
        if(_follow)
        {
            _player = GameObject.Find("Player").transform;

            Vector3 delta = transform.position - _player.position;
            delta.Normalize();
            float moveSpeed = _speed * Time.deltaTime;
            transform.position = transform.position - (delta * moveSpeed);
        }
    }
    // ����� ����������� ������
    public void DestroyBonus()
    {
        Destroy(gameObject); 
    }
}
