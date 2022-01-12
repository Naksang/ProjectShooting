using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Create : MonoBehaviour
{
    public Transform _createPos;

    public GameObject _enemySource;

    GameObject boss = null;

    private void Start()
    {
        boss = Instantiate(_enemySource);
        boss.transform.position = this.transform.position;
    }

    void Update()
    {
        if (boss.transform.position.y > 4.0f) 
        {
            boss.transform.Translate(Vector3.down * 2.0f * Time.deltaTime);

        }

    }
}
