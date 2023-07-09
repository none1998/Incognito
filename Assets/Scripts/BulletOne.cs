using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOne : MonoBehaviour
{
    private float speed;
    private Transform incognitoPos;
    private GameObject incognito;
    private float tempPos;
    private float startingPos;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        incognito = GameObject.Find("Incognito");
        startingPos = transform.position.x;
    }

    void Update()
    {
        speed = incognito.transform.localScale.x;
        if(speed > 0 && rb.velocity == new Vector2(0,0))
        rb.velocity = new Vector2(10,0);
        else if(speed < 0 && rb.velocity == new Vector2(0,0))
        rb.velocity = new Vector2(-10,0);
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Enemy")
        Destroy(other.gameObject);
        if(other.gameObject.tag != "Coin")
        Destroy(this.gameObject);
        if(other.gameObject.name == "Boss3")
        Boss3Health.newHealth -= 1;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Enemy")
        Destroy(other.gameObject);
        if(other.gameObject.tag != "Coin")
        Destroy(this.gameObject);
    }
}
