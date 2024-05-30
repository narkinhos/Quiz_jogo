using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NOME : MonoBehaviour
{
    public string username;
    public GameObject inputfield;
    public GameObject textdisplay;
    public GameObject bstart;

    public void viewname() 
    {
        username = inputfield.GetComponent<Text>().text;
        textdisplay.GetComponent<Text>().text = "Sej� bem vindo " + username + " ao nosso jogo atenciosamente grupo 4";
        bstart.SetActive (true);
    }
}
