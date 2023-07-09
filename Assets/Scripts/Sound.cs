using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private SpriteRenderer sr;
    private AudioSource mainAudio;

    // Start is called before the first frame update
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        mainAudio = GameObject.Find("Soundtrack1").GetComponent<AudioSource>();
        sr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            sr.enabled = !sr.enabled;
        }

        if(sr.enabled == true){
            mainAudio.volume = 0f;
        }
        else {
            mainAudio.volume = 0.2f;
        }
    }
}
