using UnityEngine;
/// <summary>
/// ������ ����� ������������ ������� ������������ ������ � �������� � ������������
/// </summary>
public class Player : MonoBehaviour
{
    GameObject _gameManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
            Enemy();
        if(collision.gameObject.tag == "Bonus")
            Bonus();
    }
    //����� ������������ � �����������
    void Enemy()
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().GameOver();
    }
    //����� ������������ � ��������
    void Bonus()
    {
        FindObjectOfType<GameManager>().Score();
    }
}
