using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArma : MonoBehaviour
{
    public GameObject pistolaSeleccionada;
    public GameObject pistolaMesa;
    public Player_Move helperPM;
    public bool auxInside = false;
    public PensamientoCogerArmaController helperCanvas;

    // Start is called before the first frame update
    void Start()
    {
        pistolaSeleccionada.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && auxInside){
             pistolaMesa.SetActive(false);
             pistolaSeleccionada.SetActive(true);
             helperPM.poderDisparar = true;
             helperCanvas.auxEliminarCanvas = true;
       }
    }

    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player" ){
             auxInside = true;
        }
    }

}
