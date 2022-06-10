using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaBarraVida : MonoBehaviour
{
    public int vidaMaxima;
    public float vidaActual;
    public Image barraVida;
    

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMaxima;
    }

    // Update is called once per frame
    void Update()
    {
        RevisarVida();

    }

    public void RevisarVida(){
        barraVida.fillAmount = vidaActual / vidaMaxima;
    }

    
}
