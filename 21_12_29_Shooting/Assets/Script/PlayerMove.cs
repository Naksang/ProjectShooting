using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject FireSource;

    [SerializeField]
    GameObject[] _playerSprite;

    float _speed = 5.0f;

    void Start()
    {


    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.right * h + Vector3.up * v;

        this.transform.Translate(dir * _speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject fire = FireSource;
            fire.transform.position = this.transform.position;
        }
    }
}
