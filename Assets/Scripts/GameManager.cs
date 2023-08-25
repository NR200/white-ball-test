using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// ������ ����� �������� �� ������ ����, ������� �����, ���������� ����
/// </summary>
public class GameManager : MonoBehaviour
{
    [SerializeField] Text _textScore; //��������� ���� �����
    [SerializeField] GameObject _textStart; //��������� ���� ������

    int _score; //���������� ��� �������� �����
    void Start()
    {
        NewGame();
    }
    //����� ������ ����� ����: ���������� ���� � ������ ���� �� �����
    void NewGame()
    {
        _score = 0;
        _textScore.text = _score.ToString();
        _textStart.SetActive(true);
        Time.timeScale = 0;
    }
    //����� ������ ����: ������� ���� � �����
    void StartGame()
    {
        _textStart.SetActive(false);
        Time.timeScale = 1;
    }
    //����� �������� �����
    public void Score()
    {
        _score ++;
        _textScore.text = _score.ToString();
        Debug.Log("score = " + _score);
    }
    //����� ��������� � ����������� ����
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Update()
    {
        //��������� ������� �� ������� ��� ������ ����
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
            StartGame();
    }
}
