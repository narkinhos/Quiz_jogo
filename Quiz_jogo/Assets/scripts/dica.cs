using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dica : MonoBehaviour
{
    public GameObject txtdica;
    public DISPLATDICA script;
    // public int qntd = 3; colocar no codigo do display

    public void DIQUINHA()
    {
        script.qntd--;
        txtdica.SetActive(true);
        gameObject.SetActive(false);
    }
}
