using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    Animator[] _fireAni = null;

    int _initfire;

    void Start()
    {
        _fireAni = GetComponentsInChildren<Animator>();

        _initfire = 0;
    }

    void Update()
    {

        //_fireAni[_initfire].SetBool("fire_off", true);

    }

    public void LevelUpFire()
    {
        
    }
}
