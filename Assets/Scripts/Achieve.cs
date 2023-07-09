using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achieve : MonoBehaviour
{
    public static float score1;
    public static float score2;
    public static float score3;
    public static float score4;
    public static float score5;
    public static float score6;
    public static float score7;
    public static float score8;

    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;
    public Text scoreText4;
    public Text scoreText5;
    public Text scoreText6;
    public Text scoreText7;
    public Text scoreText8;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText1.text = score1.ToString();
        scoreText2.text = score2.ToString();
        scoreText3.text = score3.ToString();
        scoreText4.text = score4.ToString();
        scoreText5.text = score5.ToString();
        scoreText6.text = score6.ToString();
        scoreText7.text = score7.ToString();
        scoreText8.text = score8.ToString();
    }
}
