using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Move : MonoBehaviour
{
    public Animator _animater;
    SpriteRenderer _rend;

    float _speed = 2.0f;
    int _hp = 2;
    bool _die = false;

    Vector3 dir;

    void Start()
    {
        _animater = GetComponentInChildren<Animator>();
        _rend = this.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
        dir = Vector3.down;
    }

    void Update()
    {
        if(!_die)
        {
            this.transform.Translate(dir * _speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerFire"))
        {
            if (_hp == 0)
            {
                _die = true;

                _animater.SetBool("expl", true);
                _animater = null;

                Enemy1Fire ef = this.GetComponent<Enemy1Fire>();
                ef.enabled = false;

                Transform fire = this.transform.GetChild(0).transform.GetChild(0);

                fire.gameObject.SetActive(false);

                Destroy(collision.gameObject);


                GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();
                gm.Score += 100;
            }
            else
            {
                _hp--;
                Destroy(collision.gameObject);
                StartCoroutine(ChangeColor());
            }
        }
    }

    IEnumerator ChangeColor()
    {
        _rend.color = new Color(1, 0, 0, 1);

        yield return new WaitForSeconds(0.05f);

        _rend.color = new Color(1, 1, 1, 1);
    }
}
