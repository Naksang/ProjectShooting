using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Move : MonoBehaviour
{
    public Animator _animater;
    public GameObject[] removeParts;

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

            _animater.SetBool("expl", true);

            Destroy(collision.gameObject);
        }
    }
    public void DestroyPart(int index)
    {
        if (removeParts != null && index >= 0 && index < removeParts.Length)
            Destroy(removeParts[index]);
        else
            Debug.LogWarning("Index is out of range in DestroPart. index: " + index);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
