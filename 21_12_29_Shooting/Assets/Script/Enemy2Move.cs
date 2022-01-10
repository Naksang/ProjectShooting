using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Move : MonoBehaviour
{
    public GameObject _explosion;
    public GameObject _score;

    float _speed = 2.0f;

    Vector3 dir;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        dir = (player.transform.position - this.transform.position);
        dir.Normalize();
    }

    void Update()
    {
        this.transform.position += dir * _speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerFire"))
        {
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            gm.Score += 100;

            GameObject explotion = Instantiate(_explosion);
            explotion.transform.position = this.transform.position;

            GameObject score = Instantiate(_score);
            score.transform.position = this.transform.position;

            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
