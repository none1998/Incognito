using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public static bool I = false;
    public static bool N = false;
    public static bool C = false;
    public static bool O = false;
    public static bool G = false;
    public static bool N2 = false;
    public static bool I2 = false;
    public static bool T = false;
    public static bool O2 = false;

    private GameObject findLetter_I;
    private GameObject findLetter_N;
    private GameObject findLetter_C;
    private GameObject findLetter_O;
    private GameObject findLetter_G;
    private GameObject findLetter_N2;
    private GameObject findLetter_I2;
    private GameObject findLetter_T;
    private GameObject findLetter_O2;


    void Awake(){
        findLetter_I = GameObject.Find("Dark_I");
        findLetter_N = GameObject.Find("Dark_N");
        findLetter_C = GameObject.Find("Dark_C");
        findLetter_O = GameObject.Find("Dark_O");
        findLetter_G = GameObject.Find("Dark_G");
        findLetter_N2 = GameObject.Find("Dark_A");
        findLetter_I2 = GameObject.Find("Dark_Z");
        findLetter_T = GameObject.Find("Dark_T");
        findLetter_O2 = GameObject.Find("Dark_E");
    }

    void Update(){
        if(I == true){
            findLetter_I.gameObject.SetActive(false);
        }
        if(N == true){
            findLetter_N.gameObject.SetActive(false);
        }
        if(C == true){
            findLetter_C.gameObject.SetActive(false);
        }
        if(O == true){
            findLetter_O.gameObject.SetActive(false);
        }
        if(G == true){
            findLetter_G.gameObject.SetActive(false);
        }
        if(N2 == true){
            findLetter_N2.gameObject.SetActive(false);
        }
        if(I2 == true){
            findLetter_I2.gameObject.SetActive(false);
        }
        if(T == true){
            findLetter_T.gameObject.SetActive(false);
        }
        if(O2 == true){
            findLetter_O2.gameObject.SetActive(false);
        }
    }

}
