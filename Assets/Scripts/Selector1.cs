using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Selector1 : MonoBehaviour
{
    private float tempPos;
    private float tempPosY;

    private string loadFilePath, loadFileName, loadedScene;

    public GameObject lock2, lock3, lock4, lock5, lock6, lock7, lock8;

    void Awake()
    {
        loadFileName = "save.txt";
        loadFilePath = Application.dataPath + "/" + loadFileName;
        //loadFilePath = loadFileName;
    }

    void Update()
    {
        if(File.Exists(loadFilePath) == true){
            loadedScene = File.ReadAllText(loadFilePath);
            if(loadedScene == "Level2"){
                lock2.SetActive(false);
            }
            else if(loadedScene == "Level3"){
                lock2.SetActive(false);
                lock3.SetActive(false);
            }
            else if(loadedScene == "Level4"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
            }
            else if(loadedScene == "Level5"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
            }
            else if(loadedScene == "Level6"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
            }
            else if(loadedScene == "Level7"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
                lock7.SetActive(false);
            }
            else if(loadedScene == "Level7"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
                lock7.SetActive(false);
                lock8.SetActive(false);
            }
            else if(loadedScene == "Level8"){
                lock2.SetActive(false);
                lock3.SetActive(false);
                lock4.SetActive(false);
                lock5.SetActive(false);
                lock6.SetActive(false);
                lock7.SetActive(false);
                lock8.SetActive(false);
            }
        }
        
        if(Input.GetKeyDown(KeyCode.RightArrow)  && tempPos < 12.20f){
            tempPos = transform.position.x;
            tempPos += 4.07f;
            Debug.Log(tempPos);
            transform.position = new Vector2(tempPos, transform.position.y);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && tempPos > 1f){
            tempPos = transform.position.x;
            tempPos -= 4.07f;
            Debug.Log(tempPos);
            transform.position = new Vector2(tempPos, transform.position.y);
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && tempPosY < 0){
            tempPosY = transform.position.y;
            tempPosY += 3.39f;
            Debug.Log(tempPosY);
            transform.position = new Vector2(transform.position.x, tempPosY);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) && tempPosY > -2.96f){
            tempPosY = transform.position.y;
            tempPosY -= 3.39f;
            Debug.Log(tempPosY);
            transform.position = new Vector2(transform.position.x, tempPosY);
        }


        //Choose the Option
        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 0f 
                                           && Mathf.Round(tempPosY) == 0f){
            SceneManager.LoadScene("Level1");
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 4f 
                                                && Mathf.Round(tempPosY) == 0f
                                                && lock2.activeSelf == false){
            SceneManager.LoadScene("Level2");
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 8f 
                                                && Mathf.Round(tempPosY) == 0f
                                                && lock3.activeSelf == false){
            SceneManager.LoadScene("Level3");
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 12f 
                                                && Mathf.Round(tempPosY) == 0f
                                                && lock4.activeSelf == false){
            SceneManager.LoadScene("Level4");
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 0f 
                                                && Mathf.Round(tempPosY) == -3f
                                                && lock5.activeSelf == false){
            SceneManager.LoadScene("Level5");
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 4f 
                                                && Mathf.Round(tempPosY) == -3f
                                                && lock6.activeSelf == false){
            SceneManager.LoadScene("Level6");
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 8f 
                                                && Mathf.Round(tempPosY) == -3f
                                                && lock7.activeSelf == false){
            SceneManager.LoadScene("Level7");
        }
        else if(Input.GetKeyDown(KeyCode.Space) && Mathf.Round(tempPos) == 12f 
                                                && Mathf.Round(tempPosY) == -3f
                                                && lock8.activeSelf == false){
            SceneManager.LoadScene("Level8");
        }
    }
}
