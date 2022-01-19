using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    Animator[] _lifeAni = null;

    int _initLife;

    void Start()
    {
        _lifeAni = GetComponentsInChildren<Animator>();

        _initLife = 2;
    }

    void Update()
    {
        

    }

    public void Damaged()
    {
        if (_initLife < 0) return;

        _lifeAni[_initLife].SetBool("Die", true);
        _initLife--;
    }

}
