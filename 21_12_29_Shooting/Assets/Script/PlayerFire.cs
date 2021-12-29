using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject _fireSource;

    public Transform _firePosition;

    public int _poolSize = 50;
    public List<GameObject> _fireObjectPool;

    void Start()
    {
        _fireObjectPool = new List<GameObject>();

        for(int i =0; i < _poolSize; i++)
        {
            GameObject fire = Instantiate(_fireSource);
            _fireObjectPool.Add(fire);
            fire.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(_fireObjectPool.Count > 0)
            {
                GameObject fire = _fireObjectPool[0];
                fire.SetActive(true);
                _fireObjectPool.Remove(fire);
                fire.transform.position = _firePosition.position;
            }
        }
    }
}
