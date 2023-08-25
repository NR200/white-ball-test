using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// Данный класс отвечает за запуск игры, подсчет очков, перезапуск игры
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] Text _textScore; //текстовое поле очков
    [SerializeField] GameObject _textStart; //текстовое поле старта

    int _score; //переменная для подсчета очков
    void Start()
    {
        NewGame();
    }
    //Метод начала новой игры: сбрасывает очки и ставит игру на паузу
    void NewGame()
    {
        _score = 0;
        _textScore.text = _score.ToString();
        _textStart.SetActive(true);
        Time.timeScale = 0;
    }
    //Метод старта игры: снимает игру с паузы
    void StartGame()
    {
        _textStart.SetActive(false);
        Time.timeScale = 1;
    }
    //метод подсчета очков
    public void Score()
    {
        _score ++;
        _textScore.text = _score.ToString();
        Debug.Log("score = " + _score);
    }
    //метод окончания и перезапуска игры
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Update()
    {
        //обработка нажатия на клавишу или кнопку мыши
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
            StartGame();
    }
}
