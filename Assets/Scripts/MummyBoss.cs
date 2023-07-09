using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyBoss : MonoBehaviour
{
    private Vector2 startingPosition;
    public GameObject incognito;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        transform.position += new Vector3(2f, 0f, 0f)*Time.deltaTime;

        if(incognito.transform.position.x < -3){
            transform.position = startingPosition;
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.name == "Obs5"){
            Destroy(other.gameObject);
            Boss4Health.newHealth -= 1;
        }
    }
}