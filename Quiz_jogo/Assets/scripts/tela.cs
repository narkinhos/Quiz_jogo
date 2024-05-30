using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tela : MonoBehaviour
{

    public string NomeDaCena;
    public void TrocaTela()
    {
        SceneManager.LoadScene(NomeDaCena);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
