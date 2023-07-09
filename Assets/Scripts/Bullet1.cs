using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    private Vector3 tempRot;

    private GameObject player;

    private Rigidbody2D rb;

    public float force;

    private Transform incognito1;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        GameObject player1 = GameObject.FindWithTag("Player");
        incognito1 = player1.GetComponent<Transform>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            Health.incognitoHealth -= 1;
            incognito1.transform.position = Incognito.startingPosition;
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "Ground")
        Destroy(this.gameObject);
    }

}
