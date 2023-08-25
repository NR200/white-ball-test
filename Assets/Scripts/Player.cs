using UnityEngine;
/// <summary>
/// Данный класс обрабатывает события столкновений игрока с бонусами и препятсвиями
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
    //метод столкновения с препятсвием
    void Enemy()
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().GameOver();
    }
    //метод столкновения с бонусами
    void Bonus()
    {
        FindObjectOfType<GameManager>().Score();
    }
}
