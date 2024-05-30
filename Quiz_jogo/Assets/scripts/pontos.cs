using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pontos : MonoBehaviour
{

    public int i = 1;
    public float Pont;
    public GameObject display;
    public GameObject display2;
    public GameObject BS;
    public GameObject FN;

    public void Update()
    {
        display.GetComponent<Text>().text = "Pontos: " + Pont.ToString("F0");
        display2.GetComponent<Text>().text = "Pontos: " + Pont.ToString("F0");
        if (i == 11) 
        {
            FN.SetActive(true);
            BS.SetActive(false);
        }
    }
}
