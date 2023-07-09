using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject incognito;
    private Vector2 coordinates;
    private float distance;
    public float throwForce;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        coordinates = transform.position - incognito.transform.position;
        distance = Mathf.Sqrt(Mathf.Pow(coordinates.y, 2) + coordinates.x*coordinates.x);
        throwForce = distance*2/3.2f;
        // when the distance is 3 throw is 2
        rb.AddForce(new Vector2(-throwForce, 1f), ForceMode2D.Impulse);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            NewHealth.newHealth -= 0.5f;
            Destroy(this.gameObject);
        }
    }
}