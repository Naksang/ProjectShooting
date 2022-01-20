using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSprite : MonoBehaviour
{
    SpriteRenderer _firespr = null;

    void Start()
    {
        _firespr = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    public void FireSpriteOff()
    {
        _firespr.enabled = false;
    }

    public void FireSpriteOn()
    {

    }
}
