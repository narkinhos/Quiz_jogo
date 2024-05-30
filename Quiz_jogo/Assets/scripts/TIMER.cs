using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TIMER : MonoBehaviour
{
    public Text cont;
    public float time = 60.0f;
    public pontos script;
    public STATUS SCRIPTADO;
    public AudioSource acb;
    public AudioSource acbnd;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0) 
        {
            time -= Time.deltaTime;
            cont.text = time.ToString("F0");
        }
        else 
        {
            //som de demorou mt pra responder
            acb.Play();
            script.i++;
            time = 30;
            SCRIPTADO.erros++;
        }
        if (time >16 && time < 17) 
        {
            //som do sonic se afogando
            acbnd.Play();
        }
    }
}
