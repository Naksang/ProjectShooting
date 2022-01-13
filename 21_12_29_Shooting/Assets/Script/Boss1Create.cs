using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Create : MonoBehaviour
{
    public Transform _createPos;

    public GameObject _enemySource;

    GameObject _boss = null;


    bool _makeboss = false;

    Transform _player;

    GameObject[] _enemy;

    public GameObject _coin;



    private void Start()
    {
        _enemy = GameObject.FindGameObjectsWithTag("Enemy");
        _enemy = GameObject.FindGameObjectsWithTag("EnemyFire");

        Destroy(GameObject.FindGameObjectsWithTag("Enemy")[GameObject.FindGameObjectsWithTag("Enemy").Length]);
        Destroy(GameObject.FindGameObjectsWithTag("EnemyFire")[GameObject.FindGameObjectsWithTag("EnemyFire").Length]);


        _boss = Instantiate(_enemySource);
        _boss.transform.position = this.transform.position;
    }

    void Update()
    {
        if(!_makeboss)
        {
            for (int i = 0; i < _enemy.Length; i++)
            {
                GameObject coin = Instantiate(_coin);
                coin.transform.position = _enemy[i].transform.position;
            }
            _makeboss = true;
        }

        else
        { 
            if (_boss.transform.position.y > 4.0f) 
            {
                _boss.transform.Translate(Vector3.down * 2.0f * Time.deltaTime);
            }
        }
    }
}
