using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocker : MonoBehaviour
{
    public GameObject lock2, lock3, lock4, lock5, lock6, lock7, lock8;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Save.tempScene);
    }

    // Update is called once per frame
    void Update()
    {
            if(Save.tempScene == "Level2"){
                lock2.SetActive(false);
            }
            else if(Save.tempScene == "Level3"){
                lock2.SetActive(false);
                lock3.SetActive(false);
            }
            else if(Save.tempScene == "Level4"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
            }
            else if(Save.tempScene == "Level5"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
            }
            else if(Save.tempScene == "Level6"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
            }
            else if(Save.tempScene == "Level7"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
                lock7.SetActive(false);
            }
            else if(Save.tempScene == "Level7"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
                lock7.SetActive(false);
                lock8.SetActive(false);
            }
            else if(Save.tempScene == "Level8"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
                lock7.SetActive(false);
                lock8.SetActive(false);
            }
        }
    
}

