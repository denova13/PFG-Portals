using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoLava : MonoBehaviour
{
    public LogicaBarraVida logicaBarraVidaJugador;
    //public Player_Move helperMovimiento;
    public float dañoLava = 10.0f;
    public bool reposoDaño = false;
    public float tiempoReposo = 1f;
    [SerializeField] private AudioSource sonidoLava;

    // Start is called before the first frame update
    void Start()
    {
        sonidoLava.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        if(!reposoDaño && logicaBarraVidaJugador.vidaActual >0){
            if(other.tag == "Player"){
                logicaBarraVidaJugador.vidaActual -= dañoLava;
                StartCoroutine(Invulnerabilidad());
                //helperMovimiento.helperRutina();
                //StartCoroutine(RealentizarJugador());
            }
        }
        
    }
    IEnumerator Invulnerabilidad(){
        reposoDaño = true;
        yield return new WaitForSeconds(tiempoReposo);
        reposoDaño = false;
    }

    /*IEnumerator RealentizarJugador(){
        var velocidadActual = helperMovimiento.velocidadMovimiento;
        helperMovimiento.velocidadMovimiento = 3;
        yield return new WaitForSeconds(tiempoReposo);
        helperMovimiento.velocidadMovimiento = velocidadActual;
    }*/
}
