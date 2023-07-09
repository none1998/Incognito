using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpRocks : MonoBehaviour
{
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Bullet"){
            rb.gravityScale = 1;
            Destroy(other.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Boss"){
            Boss2Health.newHealth -= 1;
            Destroy(this.gameObject);
        }
    }
}
