using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertaFinal : MonoBehaviour
{  
    public GameObject puertaCerrada;
    public GameObject puertaAbierta;
    public GameObject canvasFinal;
    [SerializeField] private AudioSource musicaFinal;

    // Start is called before the first frame update
    void Start()
    {
        canvasFinal.SetActive(false);
        puertaCerrada.SetActive(true);
        puertaAbierta.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            puertaCerrada.SetActive(false);
            puertaAbierta.SetActive(true);
            musicaFinal.Play();
            canvasFinal.SetActive(true);
        }
    }
}
