using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float _speed = 5.0f;
    Transform _playertrans;

    private void Start()
    {
        _playertrans = this.transform.GetChild(0);
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.right * h + Vector3.up * v;

        this.transform.Translate(dir * _speed * Time.deltaTime);

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        viewPos.x = Mathf.Clamp01(viewPos.x);
        viewPos.y = Mathf.Clamp01(viewPos.y);
        Vector3 worldPos = Camera.main.ViewportToWorldPoint(viewPos);
        transform.position = worldPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(PlayerBlink());
            
        }    
    }

    IEnumerator PlayerBlink()
    {
        _playertrans.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        _playertrans.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _playertrans.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        _playertrans.gameObject.SetActive(true);
    }
}