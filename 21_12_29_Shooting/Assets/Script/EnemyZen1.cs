using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZen1 : MonoBehaviour
{
    float _createTime = 1.0f;
    float _initTime;

    public Transform[] _createPos;

    public GameObject _enemySource;

    void Start()
    {
        
    }

    void Update()
    {
        _initTime += Time.deltaTime;
        if(_initTime > _createTime)
        {
            int rand = Random.Range(0, 5);

            if(rand == 4)
            {
                GameObject enemy = _enemySource;
                Instantiate(enemy);
                enemy.transform.position = _createPos[rand].position;
            }
            else
            {
                int rand2 = 8 - rand;
                GameObject enemy0 = _enemySource;
                Instantiate(enemy0);
                enemy0.transform.position = _createPos[rand].position;

                GameObject enemy1 = _enemySource;
                Instantiate(enemy1);
                enemy1.transform.position = _createPos[rand2].position;
            }
            _initTime = 0;
        }
    }
}