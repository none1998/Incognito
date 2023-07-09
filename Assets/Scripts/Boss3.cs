using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss3 : MonoBehaviour
{
    private float timer;

    public GameObject snowball;
    public GameObject snowPos;
    private GameObject snow;

    void Start()
    {
        timer = 1.8f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0){
            timer = 2f;
            snow = GameObject.FindWithTag("Snow");
            if(snow is not null)
            Destroy(snow.gameObject);
            Instantiate(snowball, snowPos.transform.position, Quaternion.identity);
        }
    }
}
