using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCoin : MonoBehaviour
{
    Transform _player;

    GameObject[] _enemy;

    GameObject _coin;

    void Start()
    {
        _enemy = GameObject.FindGameObjectsWithTag("Enemy");
        _enemy = GameObject.FindGameObjectsWithTag("EnemyFire");
    }

    void Update()
    {
        for(int i = 0; i< _enemy.Length; i++)
        {
            
        }
    }
}
