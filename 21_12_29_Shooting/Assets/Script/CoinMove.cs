﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    Vector3 dir;

    float _speed = 10.0f;

    bool _startmove = false;

    void Start()
    { 
        StartCoroutine(DelayTime());
    }

    void Update()
    {
        if(_startmove)
        {
            GameObject player = GameObject.Find("Player");
            dir = (player.transform.position - this.transform.position);
            dir.Normalize();

            this.transform.position += dir * _speed * Time.deltaTime;
        }
    }

    IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(1.0f);

        _startmove = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            gm.Score += 100;

            Destroy(this.gameObject);
        }
    }
}
