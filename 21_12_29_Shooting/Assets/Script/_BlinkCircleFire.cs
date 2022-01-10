using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BlinkCircleFire : MonoBehaviour
{
    public float _speed;

    public GameObject _bullet;

    void Update()
    {
        for (int i = 0; i < 360; i += 120)
        {
            transform.Rotate(Vector3.forward * _speed * 100 * Time.deltaTime);

            GameObject bullet = Instantiate(_bullet);

            Destroy(bullet, 2f);

            bullet.transform.position = this.transform.position;

            bullet.transform.rotation = this.transform.rotation;
        }
    }
}
