using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public static float timer = 5f;

    void Awake()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0f){
            timer = 5f;
            Destroy(this.gameObject);
            Incognito.isLoading = false;
        }
    }
}
