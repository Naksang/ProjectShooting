using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject _source = null;

    List<GameObject> _fireObjectPool;

    int _poolSize = 50;
    

    void Start()
    {
        _fireObjectPool = new List<GameObject>();
        for (int i = 0; i < _poolSize; i++)
        {
            GameObject fire = Instantiate(_source);
            _fireObjectPool.Add(fire);
            fire.SetActive(false);
            fire.transform.position = this.transform.position;
        }
    }
}
