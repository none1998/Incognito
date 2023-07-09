using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Selector : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.DownArrow) && tempPos > -2f){
            tempPos = transform.position.y;
            tempPos -= 1f;
            Debug.Log(tempPos);
            transform.position = new Vector2(transform.position.x, tempPos);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && tempPos < 0f){
            tempPos = transform.position.y;
            tempPos += 1f;
            Debug.Log(tempPos);
            transform.position = new Vector2(transform.position.x, tempPos);
        }


        //Choose the Option
        if(Input.GetKeyDown(KeyCode.Space) && tempPos == 0f){
            SceneManager.LoadScene("Level1");
        }
        if(Input.GetKeyDown(KeyCode.Space) && tempPos == -1f){
            SceneManager.LoadScene("Load");
        }
        if(Input.GetKeyDown(KeyCode.Space) && tempPos == -2f){
            Application.Quit();
        }
    }
}
