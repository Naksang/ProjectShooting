﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Move : MonoBehaviour
{
    public Animator _animater;

    float _speed = 2.0f;

    Vector3 dir;

    void Start()
    {
        _animater = GetComponentInChildren<Animator>();
        dir = Vector3.down;
    }

    void Update()
    {
        this.transform.Translate(dir * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerFire"))
        {
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            gm.Score += 100;



            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
