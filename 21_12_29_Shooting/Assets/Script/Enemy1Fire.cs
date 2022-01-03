using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Fire : MonoBehaviour
{
    public GameObject _enemyfire;
    bool _startfire = false;

    float _initTime;
    float _createTime = 0.5f;

    void Start()
    {
        StartCoroutine(EnemyFire());
    }

    IEnumerator EnemyFire()
    {
        yield return new WaitForSeconds(0.5f);
        _startfire = true;
    }

    void Update()
    {
        _initTime += Time.deltaTime;

        if (_startfire)
        {
            if (_initTime > _createTime)
            {
                GameObject fire = Instantiate(_enemyfire);
                fire.transform.position = this.transform.position;

                _initTime = 0;
            }
        }
    }
}
