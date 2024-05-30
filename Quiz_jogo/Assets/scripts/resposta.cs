using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resposta : MonoBehaviour
{
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    public GameObject Q8;
    public GameObject Q9;
    public GameObject Q10;
    public GameObject txtdica;

    public AudioSource acertu;
    public AudioSource erru;
    public AudioSource cong;
    public AudioSource msc;

    public pontos script;
    public STATUS SCRIPTADO;
    public TIMER SCRIPTADACO;
    public DISPLATDICA DICOSO;

    public void Acertou()
    {
        SCRIPTADO.acertos++;
        script.Pont++;
        if (SCRIPTADACO.time > 25) 
        {
            acertu.Play();
            script.Pont+=10;
        }

        if (SCRIPTADACO.time < 25 && SCRIPTADACO.time > 15)
        {
            script.Pont += 5;
        }

        if (SCRIPTADACO.time < 15 && SCRIPTADACO.time > 5)
        {
            script.Pont += 3;
        }

        script.i++;
        SCRIPTADACO.time = 30;
    }

    public void Errou()
    {
        SCRIPTADO.erros++;
        script.i++;
        erru.Play();
        SCRIPTADACO.time = 30;
    }

    private void Update()
    {
        switch (script.i)
        {
            case 2:
                Q1.SetActive(false);
                Q2.SetActive(true);
                
                if(DICOSO.qntd < 0) 
                {
                    txtdica.SetActive(false);
                }
                break;

            case 3:
                Q2.SetActive(false);
                Q3.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;

            case 4:
                Q3.SetActive(false);
                Q4.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;

            case 5:
                Q4.SetActive(false);
                Q5.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;

            case 6:
                Q5.SetActive(false);
                Q6.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;

            case 7:
                Q6.SetActive(false);
                Q7.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;

            case 8:
                Q7.SetActive(false);
                Q8.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;


            case 9:
                Q8.SetActive(false);
                Q9.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;

            case 10:
                Q9.SetActive(false);
                Q10.SetActive(true);

                if (DICOSO.qntd < 0)
                {
                    txtdica.SetActive(false);
                }
                break;

            case 11:
                Q10.SetActive(false);
                cong.Play();
                break;
        }
    }
}
