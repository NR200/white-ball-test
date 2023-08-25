using System.Collections;
using UnityEngine;
/// <summary>
/// данный класс создает объекты с заданым интервалом относительно положени€ игрока
/// </summary>
public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _object; //создаваемы объект (бонус или преп€тсвие)
    
    [SerializeField] Transform _player; //ссылка на игрока дл€ отслеживани€
    [SerializeField] float _timeSpawn; //врем€ спавна
   
    void Start()

    {
         StartCoroutine(GenerateObgect());
    }

    IEnumerator GenerateObgect()

    {
        Vector2 position;
        
        while (true)
        {
            position = _player.position; //во врем€ выполнени€ цикла получаем новые кординаты игрока
           
            position.x += Random.Range(20f, 25f);//задаем рандомную позицию спавна по кординате ’
            position.y = Random.Range(3f, -3f);//задаем рандомную позицию спавна по кординате ”

            Instantiate(_object, position, Quaternion.identity); //создаем объект
           
            yield return new WaitForSeconds(_timeSpawn);
        }
    } 
}
