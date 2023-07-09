using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Player"){
            Incognito.numOfBullets += 3;
            Destroy(this.gameObject);
        }
    }
}
