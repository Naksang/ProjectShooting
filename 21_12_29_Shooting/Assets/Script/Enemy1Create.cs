using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Create : MonoBehaviour
{
    float _createTime = 2.0f;
    float _initTime;

    public Transform[] _createPos;

    public GameObject _enemySource;

    void Update()
    {
        _initTime += Time.deltaTime;
        if(_initTime > _createTime)
        {
            int rand = Random.Range(0, 5);

            if(rand == 4)
            {
                GameObject enemy = Instantiate(_enemySource);
                enemy.transform.position = _createPos[rand].position;
            }
            else
            {
                int rand2 = 8 - rand;
                GameObject enemy0 = Instantiate(_enemySource);
                enemy0.transform.position = _createPos[rand].position;

                GameObject enemy1 = Instantiate(_enemySource);
                enemy1.transform.position = _createPos[rand2].position;
            }
            _initTime = 0;
        }
    }
}
