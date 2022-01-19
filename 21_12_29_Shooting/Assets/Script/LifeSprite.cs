using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSprite : MonoBehaviour
{
    SpriteRenderer _lifespr = null;

    void Start()
    {
        _lifespr = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }

    public void LifeSpriteOff()
    {
        _lifespr.enabled = false;
    }
}
