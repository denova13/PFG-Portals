using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaRecogerBotiquin : MonoBehaviour
{
    public LogicaBarraVida barraVida;
    public Player_Move personaje;
    public GameObject botiquin;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            botiquin.SetActive(false);
            barraVida.vidaActual = barraVida.vidaMaxima;
        }
    } 
}
