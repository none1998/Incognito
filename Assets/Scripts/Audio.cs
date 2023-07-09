using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    private AudioSource soundtrack1Audio;

    void Awake()
    {
        //soundtrack1Audio = GetComponent<AudioSource>();
        soundtrack1Audio.PlayDelayed(5f);
    }

    void Update()
    {
            
    }
}
