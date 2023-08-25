using System.Collections;
using UnityEngine;
/// <summary>
/// ������ ����� ������� ������� � ������� ���������� ������������ ��������� ������
/// </summary>
public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _object; //���������� ������ (����� ��� ����������)
    
    [SerializeField] Transform _player; //������ �� ������ ��� ������������
    [SerializeField] float _timeSpawn; //����� ������
   
    void Start()

    {
         StartCoroutine(GenerateObgect());
    }

    IEnumerator GenerateObgect()

    {
        Vector2 position;
        
        while (true)
        {
            position = _player.position; //�� ����� ���������� ����� �������� ����� ��������� ������
           
            position.x += Random.Range(20f, 25f);//������ ��������� ������� ������ �� ��������� �
            position.y = Random.Range(3f, -3f);//������ ��������� ������� ������ �� ��������� �

            Instantiate(_object, position, Quaternion.identity); //������� ������
           
            yield return new WaitForSeconds(_timeSpawn);
        }
    } 
}
