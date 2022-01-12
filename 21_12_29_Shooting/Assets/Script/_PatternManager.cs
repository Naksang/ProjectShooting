using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PatternManager : MonoBehaviour
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
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerFire"))
        {
            _hp -= collision.gameObject.GetComponent<FireMove>().Damege;
            Debug.Log(_hp);
            Destroy(collision.gameObject);

            StartCoroutine(ChangeColor());
        }
    }

    IEnumerator ChangeColor()
    {
        _rend.color = new Color(1, 0, 0, 1);

        yield return new WaitForSeconds(0.05f);

        _rend.color = new Color(1, 1, 1, 1);
    }

}
