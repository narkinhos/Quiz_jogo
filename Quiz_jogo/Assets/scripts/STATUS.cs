using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STATUS : MonoBehaviour
{
    public pontos script;
    public GameObject displaya;
    public GameObject displaye;
    public int acertos, erros;


    void Update()
    {
        displaya.GetComponent<Text>().text = "Acertos: " + acertos;
        displaye.GetComponent<Text>().text = "Erros: " + erros;
    }
}
