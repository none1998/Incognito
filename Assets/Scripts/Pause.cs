using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Pause : MonoBehaviour
{
    private float tempPos;

    private string loadFilePath, loadFileName, loadedScene;


    void Awake()
    {
        loadFileName = "save.txt";
        loadFilePath = Application.dataPath + "/" + loadFileName;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) && tempPos > -60f){
            tempPos = transform.localPosition.y;
            tempPos -= 54f;
            transform.localPosition = new Vector2(transform.localPosition.x, tempPos);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && tempPos < 45f){
            tempPos = transform.localPosition.y;
            tempPos += 54f;
            transform.localPosition = new Vector2(transform.localPosition.x, tempPos);
        }
    }
}
