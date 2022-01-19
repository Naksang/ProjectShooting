using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Move : MonoBehaviour
{
    public float _hp;
    SpriteRenderer _rend;


    void Start()
    {
        _hp = 100;
        _rend = this.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
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

    private void Triangle()
    {

    }

    private void Pentagon()
    {

    }
}
