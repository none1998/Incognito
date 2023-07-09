using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    private float tempPos;

    public string filePath, fileName;

    public Text answer;
    public Text question;
    public Text yes;
    public Text no;
    public GameObject selector;

    public static string sceneName;

    private float timer = 5f;

    private int savedYes;

    public static string tempScene;


    void Awake(){
        savedYes = 0;
    }


    void Start()
    {
        fileName = "save.txt";
        filePath = Application.dataPath + "/" + fileName;
        //filePath = fileName;
        answer.gameObject.SetActive(false);
        sceneName = "Level" + SceneManager.GetActiveScene().name.Substring(4,1);
        tempScene = "Level" + SceneManager.GetActiveScene().name.Substring(4,1);
    }

    void Update()
    {
        Debug.Log(savedYes);
        if(savedYes == 1){
            timer -= Time.deltaTime;
            if(timer < 0f){
                timer = 5f;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        if(Input.GetKeyDown(KeyCode.DownArrow) && tempPos > -1f){
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
            File.WriteAllText(filePath, sceneName);
            answer.gameObject.SetActive(true);
            question.gameObject.SetActive(false);
            yes.gameObject.SetActive(false);
            no.gameObject.SetActive(false);
            //selector.gameObject.SetActive(false);
            selector.transform.position = new Vector2(1000,1000);
            savedYes = 1;
        }
        if(Input.GetKeyDown(KeyCode.Space) && tempPos == -1f){
            question.gameObject.SetActive(false);
            yes.gameObject.SetActive(false);
            no.gameObject.SetActive(false);
            selector.gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
