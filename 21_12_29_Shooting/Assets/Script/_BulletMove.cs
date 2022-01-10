using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BulletMove : MonoBehaviour
{
    public float _speed = 10f;

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime, Space.Self);
    }
}
