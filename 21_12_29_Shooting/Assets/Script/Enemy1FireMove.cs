using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1FireMove : MonoBehaviour
{
    float _speed = 5.0f;

    Vector3 dir;

    void Start()
    {
        dir = Vector3.down;
    }

    void Update()
    {
        this.transform.Translate(dir * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
