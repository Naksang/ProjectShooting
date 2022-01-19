using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Move : MonoBehaviour
{
    public float _hp;
    SpriteRenderer _rend;

    public Vector3[] _patrolPos;
    float _speed = 2.0f;
    int _nowpos = 1;


    void Start()
    {
        _hp = 100;
        _rend = this.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();

        _patrolPos[0] = this.transform.position;
        _patrolPos[1] = new Vector3(-2, 1, 0);
    }

    void Update()
    {
        if (_hp <= 0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().Score += 600;

            GameObject cz = GameObject.Find("CreateZone");
            cz.GetComponent<Enemy1Create>().enabled = true;
            cz.GetComponent<MeteorCreate>().enabled = true;
            cz.GetComponent<Boss1Create>().enabled = false;

            Destroy(this.gameObject);
        }
        /*
        else if (_hp > 0)
        {
            switch (_nowpos)
            {
                case 0:
                    {
                        if (this.transform.position == _patrolPos[0]) _nowpos = 1;
                        else
                        {
                            Vector3 dir = _patrolPos[0] - this.transform.position;
                            this.transform.position += dir * _speed * Time.deltaTime;
                        }
                        break;
                    }
                case 1:
                    {
                        if (this.transform.position == _patrolPos[1]) _nowpos = 0;
                        else
                        {
                            Vector3 dir = _patrolPos[1] - this.transform.position;
                            this.transform.position += dir * _speed * Time.deltaTime;
                        }
                        break;
                    }
            }
        }
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerFire"))
        {
            if (_hp > 0)
            {
                _hp -= collision.gameObject.GetComponent<FireMove>().Damege;
                Debug.Log(_hp);
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
