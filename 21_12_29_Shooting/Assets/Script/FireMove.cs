using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMove : MonoBehaviour
{
    float _speed = 5.0f;

    Vector3 dir;

    void Start()
    {
        dir = Vector3.up;
    }

    void Update()
    {
        this.transform.Translate(dir * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}